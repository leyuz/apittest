using System.Collections;
using apittest.Onion.Core.Entities;

namespace apittest.Onion.Core.Repositories {
    public interface IProductRepository {
        void Add (Product p);
        void Edit (Product p);
        void Remove (int Id);
        IEnumerable GetProducts ();
        Product FindById (int Id);
    }
}