using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DataAccess
{
    public class ShopPD422Db: DbContext
    {

        public ShopPD422Db(): base() { }
        public ShopPD422Db(DbContextOptions options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //DbContextExtensions.SeedCategories(modelBuilder);
            //DbContextExtensions.SeedProducts(modelBuilder);
            modelBuilder.SeedCategories();
            modelBuilder.SeedProducts();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    string connStr = "";

        //    optionsBuilder.UseSqlServer(connStr);
        //}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
