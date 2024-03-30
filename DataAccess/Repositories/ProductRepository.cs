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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(PabnaDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            return await _dbContext.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
