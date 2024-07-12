using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext:DbContext
    {
        public DbSet<Product> Products {get;set;}

        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData
            (
                new Product(){ProductId=1,ProductName="Phone",Price=100},
                new Product(){ProductId=2,ProductName="Computer",Price=200},
                new Product(){ProductId=3,ProductName="tablet",Price=300},
                new Product(){ProductId=4,ProductName="kulaklik",Price=400},
                new Product(){ProductId=5,ProductName="sarz",Price=500}
            );
        }
    }
}