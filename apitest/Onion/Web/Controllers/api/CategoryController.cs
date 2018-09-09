using System.Collections.Generic;
using apitest1.Onion.Core.Services;
using apitest1.Onion.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace apitest1.api.Controllers {
    [Route ("api/categories")]
    public class CategoryApiController : Controller {
        private readonly ICategoryService _categoryService;

        public CategoryApiController (ICategoryService categoryService) {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll (int? count, int? page) {
            if (count == null || page == null) {
                return _categoryService.GetAll ();
            }

            return _categoryService.GetAllPaged ((int) count, (int) page);
        }
    }
}