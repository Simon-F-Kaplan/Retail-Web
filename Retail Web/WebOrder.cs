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
        [XmlAttribute("orderItems")]
        IEnumerable<WebOrderItem> OrderItems { get; set; }
    }

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
