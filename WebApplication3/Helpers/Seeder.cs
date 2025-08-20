using WebApplication3.Controllers;
using WebApplication3.Models;

namespace WebApplication3.Helpers
{
    public class Seeder
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
            new Product {
                Id = 1,
                Name = "Laptop",
                Price = 999.99m,
                Category = "Electronics" },
            new Product {
                Id = 2,
                Name = "Smartphone",
                Price = 499.99m,
                Category = "Electronics" },
            new Product {
                Id = 3,
                Name = "Tablet",
                Price = 299.99m,
                Category = "Electronics" },
            new Product {
                Id = 4,
                Name = "Headphones",
                Price = 199.99m,
                Category = "Accessories" },
            new Product {
                Id = 5,
                Name = "Smartwatch",
                Price = 249.99m,
                Category = "Wearables" }
                };
        }
    }
}
