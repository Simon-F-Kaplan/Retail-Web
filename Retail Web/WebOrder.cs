using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RetailWeb
{
    [Serializable]
    public class WebOrder
    {
        [XmlAttribute("paymentType")]
        public string PaymentType { get; set; }
        [XmlAttribute("userId")]
        public string UserId { get; set; }
        [XmlAttribute("orderCurrency")]
        public string OrderCurrency { get; set; }
        [XmlAttribute("orderDate")]
        public DateTime OrderDate { get; set; }
        [XmlAttribute("webOrderId")]
        public string WebOrderId { get; set; }
        [XmlAttribute("isPaperlessEnrolment")]
        public bool IsPaperlessEnrolment { get; set; }
        [XmlAttribute("corpDiscountApplied")]
        public bool IsCorporateDiscountApplied { get; set; }
        [XmlElement("sponsored")]
        public bool Sponsored { get; set; }
        [XmlElement("customerPaysVat")]
        public bool CustomerPaysVAT { get; set; }
        [XmlElement("preferenceType")]
        public int PreferenceType { get; set; }
        [XmlElement("voucherCode")]
        public string VoucherCode { get; set; }
        [XmlElement("shippingChargeKF")]
        public decimal ShippingChargeKF { get; set; }
        [XmlElement("shippingChargeKP")]
        public decimal ShippingChargeKP { get; set; }
        [XmlElement("orderTotalWithVat")]
        public decimal OrderTotalWithVAT { get; set; }
        [XmlElement("orderTotalExcludingVat")]
        public decimal OrderTotalExcludingVAT { get; set; }
        [XmlElement("paymentCard")]
        public PaymentCard Payment { get; set; }
        [XmlElement("addresses")]
        List<Address> Addresses { get; set; }
        [XmlElement("orderItems")]
        List<WebOrderItem> OrderItems { get; set; }
    }

    [Serializable]
    public class PaymentCard
    {
        [XmlElement("cardType")]
        public int CardType { get; set; }
        [XmlElement("cardNumber")]
        public int CardNumber { get; set; }
        [XmlElement("issueNumber")]
        public int IssueNumber { get; set; }
        [XmlElement("cardHolderName")]
        public string CardHolderName { get; set; }
        [XmlElement("startDate")]
        public DateTime StartDate { get; set; }
        [XmlElement("expiryDate")]
        public DateTime ExpiryDate { get; set; }
        [XmlElement("authorisationCode")]
        public string AuthorisationCode { get; set; }
        [XmlElement("amount")]
        public decimal Amount { get; set; }
        [XmlElement(("transactionId"))]
        public string TransactionId { get; set; }
        [XmlElement("flexible")]
        public bool Flexible { get; set; }
        [XmlElement("paymentDueDate")]
        public DateTime PaymentDueDate { get; set; }
    }

    [Serializable]
    public class Address
    { }

    [Serializable]
    public class WebOrderItem
    {
        [XmlAttribute("variant")]
        public string Variant { get; set; }
        [XmlAttribute("NAVID")]
        public string NavId { get; set; }
        [XmlAttribute("quantity")]
        public string Quantity { get; set; }
        [XmlAttribute("itemPriceWithVat")]
        public string ItemPriceWithVAT { get; set; }
        [XmlAttribute("itemPriceExVat")]
        public string ItemPriceExVAT { get; set; }
        [XmlAttribute("discountPercentage")]
        public string DiscountPercentage { get; set; }
        [XmlAttribute("company")]
        public string Company { get; set; }
        [XmlAttribute("amountPaid")]
        public string AmountPaid { get; set; }
        [XmlAttribute("productId")]
        public string ProductId { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("itemType")]
        public string ItemType { get; set; }
        [XmlAttribute(("paperMode"))]
        public string PaperMode { get; set; }
        [XmlAttribute("additionalExamSupport")]
        public string AdditionalExamSupport { get; set; }
        [XmlAttribute("sessionCode")]
        public string SessionCode { get; set; }
    }
}
