using Microsoft.EntityFrameworkCore;
using WDomain.Entities;

namespace WInfrastructure.Context
{
    /*
    IdentityDbContext--ıdentity altyapısını kullanacagımızda bundan miras aldıgımızda ıdentity tablolarını oluşturur
    hemde bizim tanimladigimiz tablolari olusturur.
    */
    public class WDbContext : DbContext
    {
        public WDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}