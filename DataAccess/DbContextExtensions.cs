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
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, CategoryId = 1 },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, CategoryId = 1 },
                new Product { Id = 3, Name = "Tablet", Price = 299.99m, CategoryId = 1 },
                new Product { Id = 4, Name = "Headphones", Price = 199.99m, CategoryId = 2 },
                new Product { Id = 5, Name = "Smartwatch", Price = 249.99m, CategoryId = 3 }
            });
        }
    }
}
