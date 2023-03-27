using Microsoft.EntityFrameworkCore;

namespace UNITOFWORK.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("products").HasKey(p => p.Id);
            modelBuilder.Entity<Order>().ToTable("Orders").HasKey(p => p.Id);
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { set; get; }

    }
}
