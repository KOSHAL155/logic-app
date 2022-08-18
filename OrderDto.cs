using System;
using System.Collections.Generic;
using System.Text;

namespace NB.OrderDataFunction
{
    public class Address
    {
        public string addressType { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string regionId { get; set; }
        public string regionName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

    public class BillingAddress
    {
        public string addressType { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string regionId { get; set; }
        public string regionName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

    public class InPayment
    {
        public string orderId { get; set; }
        public string gatewayCode { get; set; }
        public string customerId { get; set; }
        public BillingAddress billingAddress { get; set; }
        public string paymentStatus { get; set; }
        public DateTime authorizedDate { get; set; }
        public DateTime capturedDate { get; set; }
        public double price { get; set; }
        public double priceWithTax { get; set; }
        public double total { get; set; }
        public double totalWithTax { get; set; }
        public double discountAmount { get; set; }
        public double discountAmountWithTax { get; set; }
        public string objectType { get; set; }
        public double taxTotal { get; set; }
        public double taxPercentRate { get; set; }
        public List<object> taxDetails { get; set; }
        public List<object> discounts { get; set; }
        public List<object> transactions { get; set; }
        public string operationType { get; set; }
        public string number { get; set; }
        public bool isApproved { get; set; }
        public string status { get; set; }
        public string comment { get; set; }
        public string currency { get; set; }
        public double sum { get; set; }
        public List<object> childrenOperations { get; set; }
        public bool isCancelled { get; set; }
        public List<object> dynamicProperties { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public string id { get; set; }
    }

    public class Value
    {
        public string objectType { get; set; }
        public string objectId { get; set; }
        public string locale { get; set; }
        public string value { get; set; }
        public string valueType { get; set; }
        public string propertyId { get; set; }
        public string propertyName { get; set; }
    }

    public class DynamicProperty
    {
        public List<Value> values { get; set; }
        public string name { get; set; }
        public bool isArray { get; set; }
        public bool isDictionary { get; set; }
        public bool isMultilingual { get; set; }
        public bool isRequired { get; set; }
        public string valueType { get; set; }
        public DateTime createdDate { get; set; }
        public string id { get; set; }
    }

    public class Item
    {
        public string currency { get; set; }
        public double price { get; set; }
        public double priceWithTax { get; set; }
        public double placedPrice { get; set; }
        public double placedPriceWithTax { get; set; }
        public double extendedPrice { get; set; }
        public double extendedPriceWithTax { get; set; }
        public double discountAmount { get; set; }
        public double discountAmountWithTax { get; set; }
        public double discountTotal { get; set; }
        public double discountTotalWithTax { get; set; }
        public double fee { get; set; }
        public double feeWithTax { get; set; }
        public double taxTotal { get; set; }
        public double taxPercentRate { get; set; }
        public int reserveQuantity { get; set; }
        public int quantity { get; set; }
        public string productId { get; set; }
        public string sku { get; set; }
        public string productType { get; set; }
        public string catalogId { get; set; }
        public string categoryId { get; set; }
        public string name { get; set; }
        public bool isGift { get; set; }
        public bool isCancelled { get; set; }
        public string objectType { get; set; }
        public List<DynamicProperty> dynamicProperties { get; set; }
        public List<object> discounts { get; set; }
        public List<object> taxDetails { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public string id { get; set; }
        public string imageUrl { get; set; }
    }

    public class DeliveryAddress
    {
        public string addressType { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string regionId { get; set; }
        public string regionName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

    public class Shipment
    {
        public string shipmentMethodCode { get; set; }
        public string shipmentMethodOption { get; set; }
        public string customerOrderId { get; set; }
        public List<object> items { get; set; }
        public List<object> packages { get; set; }
        public List<object> inPayments { get; set; }
        public List<object> discounts { get; set; }
        public DeliveryAddress deliveryAddress { get; set; }
        public double price { get; set; }
        public double priceWithTax { get; set; }
        public double total { get; set; }
        public double totalWithTax { get; set; }
        public double discountAmount { get; set; }
        public double discountAmountWithTax { get; set; }
        public double fee { get; set; }
        public double feeWithTax { get; set; }
        public string objectType { get; set; }
        public double taxTotal { get; set; }
        public double taxPercentRate { get; set; }
        public List<object> taxDetails { get; set; }
        public string operationType { get; set; }
        public string number { get; set; }
        public bool isApproved { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public double sum { get; set; }
        public List<object> childrenOperations { get; set; }
        public bool isCancelled { get; set; }
        public List<object> dynamicProperties { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public string id { get; set; }
    }

    public class ChildrenOperation
    {
        public string orderId { get; set; }
        public string gatewayCode { get; set; }
        public string customerId { get; set; }
        public BillingAddress billingAddress { get; set; }
        public string paymentStatus { get; set; }
        public DateTime authorizedDate { get; set; }
        public DateTime capturedDate { get; set; }
        public double price { get; set; }
        public double priceWithTax { get; set; }
        public double total { get; set; }
        public double totalWithTax { get; set; }
        public double discountAmount { get; set; }
        public double discountAmountWithTax { get; set; }
        public string objectType { get; set; }
        public double taxTotal { get; set; }
        public double taxPercentRate { get; set; }
        public List<object> taxDetails { get; set; }
        public List<object> discounts { get; set; }
        public List<object> transactions { get; set; }
        public string operationType { get; set; }
        public string number { get; set; }
        public bool isApproved { get; set; }
        public string status { get; set; }
        public string comment { get; set; }
        public string currency { get; set; }
        public double sum { get; set; }
        public List<object> childrenOperations { get; set; }
        public bool isCancelled { get; set; }
        public List<object> dynamicProperties { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public string id { get; set; }
        public string shipmentMethodCode { get; set; }
        public string shipmentMethodOption { get; set; }
        public string customerOrderId { get; set; }
        public List<object> items { get; set; }
        public List<object> packages { get; set; }
        public List<object> inPayments { get; set; }
        public DeliveryAddress deliveryAddress { get; set; }
        public double? fee { get; set; }
        public double? feeWithTax { get; set; }
    }

    public class NewEntry
    {
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string storeId { get; set; }
        public string shoppingCartId { get; set; }
        public bool isPrototype { get; set; }
        public string objectType { get; set; }
        public List<Address> addresses { get; set; }
        public List<InPayment> inPayments { get; set; }
        public List<Item> items { get; set; }
        public List<Shipment> shipments { get; set; }
        public List<object> discounts { get; set; }
        public double discountAmount { get; set; }
        public List<object> taxDetails { get; set; }
        public double total { get; set; }
        public double subTotal { get; set; }
        public double subTotalWithTax { get; set; }
        public double subTotalDiscount { get; set; }
        public double subTotalDiscountWithTax { get; set; }
        public double subTotalTaxTotal { get; set; }
        public double shippingTotal { get; set; }
        public double shippingTotalWithTax { get; set; }
        public double shippingSubTotal { get; set; }
        public double shippingSubTotalWithTax { get; set; }
        public double shippingDiscountTotal { get; set; }
        public double shippingDiscountTotalWithTax { get; set; }
        public double shippingTaxTotal { get; set; }
        public double paymentTotal { get; set; }
        public double paymentTotalWithTax { get; set; }
        public double paymentSubTotal { get; set; }
        public double paymentSubTotalWithTax { get; set; }
        public double paymentDiscountTotal { get; set; }
        public double paymentDiscountTotalWithTax { get; set; }
        public double paymentTaxTotal { get; set; }
        public double discountTotal { get; set; }
        public double discountTotalWithTax { get; set; }
        public double fee { get; set; }
        public double feeWithTax { get; set; }
        public double feeTotal { get; set; }
        public double feeTotalWithTax { get; set; }
        public double taxTotal { get; set; }
        public double taxPercentRate { get; set; }
        public string languageCode { get; set; }
        public string operationType { get; set; }
        public string number { get; set; }
        public bool isApproved { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public double sum { get; set; }
        public List<ChildrenOperation> childrenOperations { get; set; }
        public bool isCancelled { get; set; }
        public List<DynamicProperty> dynamicProperties { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public string id { get; set; }
    }

    public class OldEntry
    {
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string storeId { get; set; }
        public string shoppingCartId { get; set; }
        public bool isPrototype { get; set; }
        public string objectType { get; set; }
        public List<Address> addresses { get; set; }
        public List<InPayment> inPayments { get; set; }
        public List<Item> items { get; set; }
        public List<Shipment> shipments { get; set; }
        public List<object> discounts { get; set; }
        public double discountAmount { get; set; }
        public List<object> taxDetails { get; set; }
        public double total { get; set; }
        public double subTotal { get; set; }
        public double subTotalWithTax { get; set; }
        public double subTotalDiscount { get; set; }
        public double subTotalDiscountWithTax { get; set; }
        public double subTotalTaxTotal { get; set; }
        public double shippingTotal { get; set; }
        public double shippingTotalWithTax { get; set; }
        public double shippingSubTotal { get; set; }
        public double shippingSubTotalWithTax { get; set; }
        public double shippingDiscountTotal { get; set; }
        public double shippingDiscountTotalWithTax { get; set; }
        public double shippingTaxTotal { get; set; }
        public double paymentTotal { get; set; }
        public double paymentTotalWithTax { get; set; }
        public double paymentSubTotal { get; set; }
        public double paymentSubTotalWithTax { get; set; }
        public double paymentDiscountTotal { get; set; }
        public double paymentDiscountTotalWithTax { get; set; }
        public double paymentTaxTotal { get; set; }
        public double discountTotal { get; set; }
        public double discountTotalWithTax { get; set; }
        public double fee { get; set; }
        public double feeWithTax { get; set; }
        public double feeTotal { get; set; }
        public double feeTotalWithTax { get; set; }
        public double taxTotal { get; set; }
        public double taxPercentRate { get; set; }
        public string languageCode { get; set; }
        public string operationType { get; set; }
        public string number { get; set; }
        public bool isApproved { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public double sum { get; set; }
        public List<ChildrenOperation> childrenOperations { get; set; }
        public bool isCancelled { get; set; }
        public List<DynamicProperty> dynamicProperties { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime modifiedDate { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public string id { get; set; }
    }

    public class ChangedEntry
    {
        public string entryState { get; set; }
        public NewEntry newEntry { get; set; }
        public OldEntry oldEntry { get; set; }
    }

    public class EventBody
    {
        public List<ChangedEntry> changedEntries { get; set; }
        public int version { get; set; }
        public DateTime timeStamp { get; set; }
        public string id { get; set; }
    }

    public class OrderDto
    {
        public string EventId { get; set; }
        public int Attempt { get; set; }
        public EventBody EventBody { get; set; }
    }


    public class AdditionalMemberInfoDto
    {
        public string id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public DateTime dob { get; set; }

        public string language { get; set; }

        public string gender { get; set; }

        public string ssn { get; set; }

        public IList<DependentMember> DependentMembers { get; set; }

        public AdditionalMemberInfoDto()
        {

            DependentMembers = new List<DependentMember>();
        }
    }

    public partial class DependentMember
    {
        public string id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public DateTime dob { get; set; }

        public string ssn { get; set; }

        public bool printcard { get; set; }
    }

    public class CardDetails
    {
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CardExp { get; set; }
        public string MemberCustomerProfileId { get; set; }
    }

    public class PackagePlan
    {

        public string Name { get; set; }
        public List<string> Benefits { get; set; }
        public string Plan { get; set; }
        public string Type { get; set; }
        public string ProductId { get; set; }

    }


}
