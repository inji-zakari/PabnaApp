using Microsoft.AspNetCore.Mvc;
using Pabna.Core.IServices;

namespace Pabna.WebAPI.Controllers
{
    public class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryByIdWithProducts(int categoryId)
        {
            return CreateActionResult(await _service.GetSingleCategoryByIdWithProduct(categoryId));
        }
    }
}
