using Microsoft.EntityFrameworkCore;
using Persistence.Infrastructure;

namespace Persistence
{
    public class CleanBoilerplateDbContextFactory : DesignTimeDbContextFactoryBase<CleanBoilerplateDbContext>
    {
        protected override CleanBoilerplateDbContext CreateNewInstance(DbContextOptions<CleanBoilerplateDbContext> options)
        {
            return new CleanBoilerplateDbContext(options);
        }
    }
}
