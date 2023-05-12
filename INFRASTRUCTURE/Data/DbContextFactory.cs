using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace INFRASTRUCTURE.Data
{
    public class SevenGoContextFactory : IDesignTimeDbContextFactory<SevenGoContext>
    {
        public SevenGoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlite("Data Source=INFRASTRUCTURE/Data/7GO.db");

            return new SevenGoContext(optionsBuilder.Options);
        }
    }
}