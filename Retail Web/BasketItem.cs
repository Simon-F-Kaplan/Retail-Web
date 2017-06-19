using System;
using System.Collections.Generic;
using System.Text;

namespace RetailWeb
{
    public class BasketItem
    {
        public string InternalId { get; set; }
        public string ExternalId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
