using System;
using System.Collections.Generic;
using System.Text;

namespace RetailWeb
{
    public class Basket
    {
        public string ID { get; set; }
        /// <summary>
        /// When the basket last had a discount applied
        /// </summary>
        public DateTime Discounted { get; set; }
        public IEnumerable<BasketItem> items { get; set; }
    }
}
