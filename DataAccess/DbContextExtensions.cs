using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public static class  DbContextExtensions
    {
        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Accessories" },
                new Category { Id = 3, Name = "Wearables" }
            });
        }
        public static void SeedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, CategoryId = 1, ImageUrl=@"https://img.ktc.ua/img/base/1_505/7/652987.webp" },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, CategoryId = 1, ImageUrl=@"https://content.rozetka.com.ua/goods/images/big_tile/518272249.jpg" },
                new Product { Id = 3, Name = "Tablet", Price = 299.99m, CategoryId = 1, ImageUrl=@"https://content1.rozetka.com.ua/goods/images/big/52859932.jpg" },
                new Product { Id = 4, Name = "Headphones", Price = 199.99m, CategoryId = 2, ImageUrl=@"https://marshallheadphones.com.ua/wp-content/uploads/2024/11/marshall-major-v-cream-01-800x800-1.png" },
                new Product { Id = 5, Name = "Smartwatch", Price = 249.99m, CategoryId = 3, ImageUrl=@"https://www.lapcare.com/cdn/shop/files/Fitso_3_black.jpg?v=1756209717&width=2048" }
            });
        }
    }
}
