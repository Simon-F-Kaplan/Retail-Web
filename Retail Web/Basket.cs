using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RetailWeb
{
    [Serializable]
    public class Basket
    {
        [XmlAttribute("basketid")]
        public string ID { get; set; }
        /// <summary>
        /// When the basket last had a discount applied
        /// </summary>
        [XmlIgnore()]
        public DateTime Discounted { get; set; }
        public IEnumerable<BasketItem> items { get; set; }
        [XmlIgnore]
        public decimal Total { get; set; }
    }
}
