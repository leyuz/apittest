using System;
using System.Collections.Generic;
using System.Linq;
using apitest1.Onion.Core.Services;
using apittest.Onion.Core.Entities;
using apittest.Onion.Infrastructure;
using apittest.Onion.Infrastructure.DatabaseOperations;
using Microsoft.EntityFrameworkCore;
using Xunit;
namespace Tests {

    public class ProductRepositoryTest {
        ProductRepository Repo;
        public ProductRepositoryTest () {
            Repo = CreateSUT ();
            //Arrange
            var productList = new List<Product> {
                new Product { Id = 1, inStock = true, Name = "Test1", Price = 999 },
                new Product { Id = 2, inStock = false, Name = "out of stock", Price = 100 }
            };
            //Act
            Repo.Seed (productList);
        }

        [Fact]
        public void IsRepositoryInitalizeWithValidNumberOfData () {
            var result = Repo.GetProducts ();
            Assert.NotNull (result);
            var numberOfRecords = result.ToList ().Count;
            Assert.Equal (2, numberOfRecords);
        }

        [Fact]
        public void CreateToDoList_WithValidObject_NewListIdIsNotEqualsToZero () {

            //Assert
            Assert.True (Repo.GetProducts ().Count () > 0);
        }
        private ProductRepository CreateSUT () {
            var dbOptions = new DbContextOptionsBuilder<ProductContext> ()
                .UseInMemoryDatabase (databaseName: "ProductDb")
                .Options;
            var context = new ProductContext (dbOptions);
            return new ProductRepository (context);
        }
    }
}