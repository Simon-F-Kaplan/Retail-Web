using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<BasketItem> Items { get; set; }
        [XmlIgnore]
        public decimal Total { get
            {
                return CalculateTotalItemsPrice();
            }
        }

        /// <summary>
        /// Calculate the total price of all items (
        /// </summary>
        /// <returns></returns>
        private decimal CalculateTotalItemsPrice()
        {
            if(Items.Count() == 0 || null==Items)
            { return 0; }

            decimal result = 0;
            foreach(var item in Items)
            {
                result += item.Price;
            }

            return result;
        }
    }
}
