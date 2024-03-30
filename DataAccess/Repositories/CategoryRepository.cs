using Core.Entities;
using DataAccess;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Pabna.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pabna.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(PabnaDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Category> GetCategoryByIdWithProducts(int categoryId)
        {
            return await _dbContext.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
