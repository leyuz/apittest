using System.Data;
using apittest.Onion.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace apittest.Onion.Infrastructure.DatabaseOperations {
    public class ProductContext : DbContext {
        public ProductContext (DbContextOptions<ProductContext> options) : base (options) {

        }
        public DbSet<Product> Products { get; set; }
        public static void Seed (ProductContext context) {
            {
                context.Products.Add (new Product { Id = 1, Name = "Rice", inStock = true, Price = 30 });
                context.Products.Add (new Product { Id = 2, Name = "Sugar", inStock = false, Price = 40 });
                context.SaveChanges ();
            }
        }
    }
}