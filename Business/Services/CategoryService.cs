using AutoMapper;
using Core.Entities;
using Core.IRepositories;
using Core.IUnitOfWork;
using Pabna.Core.Dtos;
using Pabna.Core.IRepositories;
using Pabna.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pabna.Service.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly IGenericRepository<Category> _repository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper) : base(categoryRepository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProduct(int categoryId)
        {
            var category = await _unitOfWork.Category.GetCategoryByIdWithProducts(categoryId);
            var categoryDto = _mapper.Map<CategoryWithProductsDto>(category);
            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryDto);
        }
    }
}
