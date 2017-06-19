using System;

namespace Retail_Web
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public bool HasDeliverables { get; set; }
        public bool IsDiscountable { get; set; }

    }
}
