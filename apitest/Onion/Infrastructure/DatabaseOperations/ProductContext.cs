using System.Data;
using apittest.Onion.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace apittest.Onion.Infrastructure.DatabaseOperations {
    public class ProductContext : DbContext {
        public ProductContext (DbContextOptions<ProductContext> options) : base (options) {

        }
        public DbSet<Product> Products { get; set; }

    }
}