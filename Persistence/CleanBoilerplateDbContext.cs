using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Persistence
{
    public class CleanBoilerplateDbContext : DbContext
    {
        public CleanBoilerplateDbContext(DbContextOptions<CleanBoilerplateDbContext> options)
            : base(options)
        {

        }

        public DbSet<Intermediary> Intermediaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CleanBoilerplateDbContext).Assembly);
        }
    }
}
