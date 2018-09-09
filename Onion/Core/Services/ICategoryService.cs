using System.Collections.Generic;
using apitest1.Onion.Domain.Models;
using apitest1.Onion.Domain.Services;

namespace apitest1.Onion.Core.Services {
    public interface ICategoryService {
        IEnumerable<Category> GetAll ();
        IEnumerable<Category> GetAllPaged (int count, int page);
    }
}