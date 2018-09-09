using System.Linq;
using apittest.Onion.Infrastructure;
using apittest.Onion.Infrastructure.DatabaseOperations;
using Microsoft.EntityFrameworkCore;
using Xunit;
namespace apittest.Onion.Tests {
    public class ProductRepositoryTest {
        private readonly ProductRepository _Repo;
        ProductRepositoryTest () {
            var options = new DbContextOptions<ProductContext> ();
            var ctx = new ProductContext (options);
            _Repo = new ProductRepository (ctx);
        }

        [Fact]
        public void IsRepositoryInitalizeWithValidNumberOfData () {
            var result = _Repo.GetProducts ();
            Assert.NotNull (result);
            var numberOfRecords = result.ToList ().Count;
            Assert.Equal (2, numberOfRecords);
        }
    }
}