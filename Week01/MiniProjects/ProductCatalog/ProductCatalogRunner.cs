namespace Week01.MiniProjects.ProductCatalog;

public static class ProductCatalogRunner
{
    public static void Run()
    {
        List<Product> products =
        [
            new()
            {
                Name = "Laptop",
                Price = 65000,
                Category = ProductCategory.Electronics
            },

            new()
            {
                Name = "Phone",
                Price = 30000,
                Category = ProductCategory.Electronics
            },

            new()
            {
                Name = "T-Shirt",
                Price = 1000,
                Category = ProductCategory.Clothing
            },

            new()
            {
                Name = "Jeans",
                Price = 2500,
                Category = ProductCategory.Clothing
            },

            new()
            {
                Name = "Chocolate",
                Price = 100,
                Category = ProductCategory.Food
            }
        ];

        foreach (ProductCategory category in Enum.GetValues<ProductCategory>())
        {
            Console.WriteLine($"\n=== {category} ===");

            var categoryProducts =
                products.Where(p => p.Category == category);

            foreach (Product product in categoryProducts)
            {
                Console.WriteLine(
                    $"{product.Name} - ₹{product.Price}");
            }
        }
    }
}