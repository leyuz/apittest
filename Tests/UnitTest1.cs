using System;
using System.Collections.Generic;
using System.Linq;
using apitest1.Onion.Core.Services;
using apittest.Onion.Core.Entities;
using apittest.Onion.Infrastructure;
using apittest.Onion.Infrastructure.DatabaseOperations;
using Microsoft.EntityFrameworkCore;
using Xunit;
namespace Tests
{
    public class DatabaseFixure : IDisposable
    {
        public ProductRepository Repo { get; private set; }
        public DatabaseFixure()
        {

            Repo = CreateSUT();
            //Arrange
            var productList = new List<Product> {
                new Product { Id = 1, inStock = true, Name = "Test1", Price = 999 },
                new Product { Id = 2, inStock = false, Name = "out of stock", Price = 100 }
            };
            //Act
            Repo.Seed(productList);
        }
        public void Dispose()
        {
            Repo = null;
        }
        private ProductRepository CreateSUT()
        {
            var dbOptions = new DbContextOptionsBuilder<ProductContext>()
                .UseInMemoryDatabase(databaseName: "ProductDb")
                .Options;
            var context = new ProductContext(dbOptions);
            return new ProductRepository(context);
        }
    }
    public class ProductRepositoryTest : IClassFixture<DatabaseFixure>
    {
        ProductRepository Repo;
        public ProductRepositoryTest(DatabaseFixure fixure)
        {
            Repo = fixure.Repo;
        }

        [Fact]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
            var result = Repo.GetProducts();
            Assert.NotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.Equal(2, numberOfRecords);
        }

        [Fact]
        public void CreateToDoList_WithValidObject_NewListIdIsNotEqualsToZero()
        {

            //Assert
            Assert.True(Repo.GetProducts().Count() > 0);
        }

    }
}