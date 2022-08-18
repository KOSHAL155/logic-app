using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Collections.Generic;

using static NB.OrderDataFunction.Models.PackageConstants;
using static NB.OrderDataFunction.Models.OrderContants;

namespace NB.OrderDataFunction
{
    public static class OrderDataTransformFunction
    {

        [FunctionName("OrderDataTransformFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

                var data = JsonConvert.DeserializeObject<OrderDto>(requestBody);
                AddDirectSubscriberRequest reqObject = new AddDirectSubscriberRequest();
                if (data != null)
                {
                    var newEntry = data.EventBody.changedEntries[0].newEntry;
                    var oldEntry = data.EventBody.changedEntries[0].oldEntry;
                    if (newEntry.inPayments[0].paymentStatus == PaymentStatuses.Paid && oldEntry.inPayments[0].paymentStatus == PaymentStatuses.New)
                    {

                        string cardDetails = newEntry.dynamicProperties.FirstOrDefault(p => p.name == Properties.CardDetails).values?.FirstOrDefault().value;
                        var CardDetailsDTO = JsonConvert.DeserializeObject<CardDetails>(cardDetails);
                        reqObject.MemberCustomerProfileId = Convert.ToInt32(CardDetailsDTO.MemberCustomerProfileId);

                        string packageData = newEntry.dynamicProperties.FirstOrDefault(p => p.name == Properties.PackagePlan).values?.FirstOrDefault().value;
                        var packagePlanDeserialized = JsonConvert.DeserializeObject<List<PackagePlan>>(packageData);
                        List<NBProduct> nBProducts = new List<NBProduct>();
                        foreach (var package in packagePlanDeserialized)
                        {
                            NBProduct nBProduct = new NBProduct();
                            if (package.Type == "NBPackage")
                            {
                                nBProduct.Plan = package.Plan == "Year" ? PackagePlans.Annual: PackagePlans.Monthly;
                                nBProduct.Benefits = package.Benefits;
                            }
                            nBProduct.Name = package.Name;
                            nBProduct.Type = package.Type;
                            nBProducts.Add(nBProduct);
                        }
                        reqObject.Products = nBProducts;

                        reqObject.MembershipTypeName = nBProducts.FirstOrDefault(p => p.Type == "NBPackage")?.Plan;
                        reqObject.GroupNumber = newEntry.storeId;
                        reqObject.PackageName = newEntry.items.FirstOrDefault(p => p.productId == packagePlanDeserialized.FirstOrDefault().ProductId).name;

                        var addressObj = newEntry.addresses.FirstOrDefault(p => (p.addressType == "Shipping" || p.addressType == "BillingAndShipping"));
                        reqObject.AddressLine1 = addressObj.line1;
                        reqObject.AddressLine2 = addressObj.line2;
                        reqObject.City = addressObj.city;
                        reqObject.State = addressObj.regionId;
                        reqObject.Zip = addressObj.postalCode;

                        var subscriberDTOobj = newEntry.dynamicProperties.FirstOrDefault(p => p.name == "BenefitInformation").values?.FirstOrDefault().value;
                        var subscriberDTO = JsonConvert.DeserializeObject<AdditionalMemberInfoDto>(subscriberDTOobj);
                        Subscriber primarySubscriber = new Subscriber
                        {
                            RecordType = "A",
                            FirstName = subscriberDTO.firstname,
                            LastName = subscriberDTO.lastname,
                            BirthDate = subscriberDTO.dob,
                            Language = subscriberDTO.language ?? "E",
                            UniqueIdentifier = subscriberDTO.id,
                            EmailAddress = addressObj.email,
                            HomePhone = addressObj.phone
                        };
                        reqObject.Subscribers.Add(primarySubscriber);

                        foreach (var dependent in subscriberDTO.DependentMembers)
                        {
                            Subscriber dependentMember = new Subscriber
                            {
                                UniqueIdentifier = dependent.id,
                                RecordType = "D",
                                FirstName = dependent.firstname,
                                LastName = dependent.lastname,
                                BirthDate = dependent.dob,
                                Language = subscriberDTO.language
                            };
                            reqObject.Subscribers.Add(dependentMember);
                        }

                        reqObject.OrderDetailPayload = requestBody;

                        var resellerId = newEntry.dynamicProperties.FirstOrDefault(x => x.name == "ResellerId")?.values?.FirstOrDefault()?.value;
                        reqObject.ResellerID = resellerId;

                        var AffiliationCodeObj = newEntry.dynamicProperties.FirstOrDefault(x => x.name == "AffiliationCode")?.values?.FirstOrDefault()?.value;
                        reqObject.AffiliationCode = AffiliationCodeObj;

                        var jsonSettings = new JsonSerializerSettings
                        {
                            DateFormatString = "yyyy-MM-dd"
                        };

                        return new JsonResult(reqObject, jsonSettings);
                    }
                }
            }
            catch (Exception ex)
            {
                var result = new ObjectResult(ex.ToString())
                {
                    StatusCode = StatusCodes.Status206PartialContent
                };
                return result;
            }
            var fresult = new ObjectResult("Ignore the request")
            {
                StatusCode = StatusCodes.Status206PartialContent
            };
            return fresult;
        }
    }
}
