using Core.Entities;
using Pabna.Core.Dtos;
namespace Pabna.Core.IServices
{
    public interface IProductService : IGenericService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
