using System.Collections.Generic;
using apitest1.Onion.Core.Services;
using apitest1.Onion.Domain.Models;

namespace apitest1.Onion.Domain.Services {
    public class CategoryService1 : ICategoryService {
        public IEnumerable<Category> GetAll () {
            var result = new List<Category> ();
            var cat = new Category ();
            cat.Name = "Get All";
            result.Add (cat);
            return result;
        }

        public IEnumerable<Category> GetAllPaged (int count, int page) {
            var result = new List<Category> ();

            for (int i = 0; i < count; i++) {
                var cat = new Category ();
                result.Add (cat);
                cat.Name = "Name #" + i;
            }

            return result;
        }
    }
}