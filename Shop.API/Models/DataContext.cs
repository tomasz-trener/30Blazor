using Microsoft.EntityFrameworkCore;
using Shop.DataSeeder;
using Shop.Shared;
using Shop.Shared.Auth;

namespace Shop.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(ProductDataSeeder.GenerateProductsData());
        }
    }
}
