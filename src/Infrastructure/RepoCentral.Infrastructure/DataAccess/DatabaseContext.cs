namespace RepoCentral.Infrastructure.DataAccess;

public class DatabaseContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Repo> Repos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Fluent API configuration (if needed)
    }
}
