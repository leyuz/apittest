using System.Collections;
using System.Collections.Generic;
using System.Linq;
using apittest.Onion.Core.Entities;
using apittest.Onion.Core.Repositories;
using apittest.Onion.Infrastructure.DatabaseOperations;

namespace apittest.Onion.Infrastructure {
    public class ProductRepository : IProductRepository {
        private readonly ProductContext _productContext;

        public ProductRepository (ProductContext productContext) {
            _productContext = productContext;
        }
        public void Add (Product p) {
            _productContext.Products.Add (p);
            _productContext.SaveChanges ();
        }
        public void Edit (Product p) { }
        public Product FindById (int Id) {
            var result = (from r in _productContext.Products where r.Id == Id select r).FirstOrDefault ();
            return result;
        }
        public void Remove (int Id) {
            throw new System.NotImplementedException ();
        }
        public IEnumerable<Product> GetProducts () {
            var result = _productContext.Products;
            return result;
        }
        public void Seed (List<Product> productList) {
            {
                _productContext.Products.AddRange (productList);
                _productContext.SaveChanges ();
            }
        }
    }
}