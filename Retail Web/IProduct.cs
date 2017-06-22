namespace Retail_Web
{
    public interface IProduct
    {
        string Name { get; set; }
        bool HasDeliverables { get; set; }
        bool IsDiscountable { get; set; }
        decimal Price { get; set; }
    }
}