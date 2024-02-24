using Microsoft.EntityFrameworkCore;

namespace SMS.WebApi.DataBaseContext;

public class ApplicationDB(DbContextOptions<ApplicationDB> dbContext) : DbContext(dbContext)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDB).Assembly);
    }
}
