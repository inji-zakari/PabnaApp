using Core.IUnitOfWork;
using Pabna.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PabnaDbContext _dbContext;
        public UnitOfWork(PabnaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
