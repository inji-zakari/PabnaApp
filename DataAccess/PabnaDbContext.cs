using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PabnaDbContext : DbContext
    {
        public PabnaDbContext(DbContextOptions<PabnaDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<PopularTag> PopularTags { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SortBy> SortBies { get; set; }
    }
}
