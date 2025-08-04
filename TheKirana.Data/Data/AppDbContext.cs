using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TheKirana.Model.Models;

namespace TheKirana.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define DbSets for your entities
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }






        // optionBuilder.UseSqlServer("Server=DESKTOP-R54CT7O;Database=TheKirana;Trusted_Connection=True;TrustServerCertificate=True;");


    }

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=TheKirana;Trusted_Connection=True;TrustServerCertificate=True;");
            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
