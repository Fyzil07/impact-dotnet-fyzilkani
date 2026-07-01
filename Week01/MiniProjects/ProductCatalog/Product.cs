namespace Week01.MiniProjects.ProductCatalog;

public class Product
{
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public ProductCategory Category { get; set; }
}