using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions<MarketContext>options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
