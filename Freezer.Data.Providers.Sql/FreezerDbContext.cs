namespace Freezer.Data.Providers.Sql
{
    using Models;

    using Microsoft.EntityFrameworkCore;

    public class FreezerDbContext : DbContext
    {
        public FreezerDbContext(DbContextOptions<FreezerDbContext> options)
            : base(options)
        { }

        public DbSet<Freezer> Freezers { get; set; }
    }
}
