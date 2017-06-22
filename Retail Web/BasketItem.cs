using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RetailWeb
{
    [Serializable()]
    public class BasketItem
    {
        [XmlAttribute("internalid")]
        public string InternalId { get; set; }
        [XmlAttribute("externalid")]
        public string ExternalId { get; set; }
        [XmlAttribute("quantity")]
        public int Quantity { get; set; }
        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
