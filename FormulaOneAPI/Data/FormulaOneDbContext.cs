using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Xml;

namespace FormulaOneAPI.Data
{
    public class FormulaOneDbContext : DbContext
    {
        public FormulaOneDbContext(DbContextOptions<FormulaOneDbContext> options) : base(options)
        {
        }

        public DbSet<MyEntity> MyEntities { get; set; }
    }
}
