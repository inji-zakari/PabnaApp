using Core.Entities;
using Pabna.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pabna.Core.IServices
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProduct(int categoryId);
    }
}
