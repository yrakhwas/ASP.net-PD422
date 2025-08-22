using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ShopPD422Db: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
