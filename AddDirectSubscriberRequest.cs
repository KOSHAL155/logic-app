using System;
using System.Collections.Generic;
using System.Text;

namespace NB.OrderDataFunction
{
    public class AddDirectSubscriberRequest
    {
        public AddDirectSubscriberRequest()
        {
            Subscribers = new List<Subscriber>();
        }
        public int MemberCustomerProfileId { get; set; }
        public string GroupNumber { get; set; }
        public string PackageName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string MembershipTypeName { get; set; }
        public List<NBProduct> Products { get; set; }
        public List<Subscriber> Subscribers { get; set; }
        public string OrderDetailPayload { get; set; }
        public string ResellerID { get; internal set; }
        public string AffiliationCode { get; set; }
    }

    public class Subscriber
    {
        public string RecordType { get; set; }
        public string UniqueIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public string Language { get; set; }
    }

    public class NBProduct
    {
        public string Name { get; set; }
        public List<string> Benefits { get; set; }
        public string Plan { get; set; }
        public string Type { get; set; }
    }


}
