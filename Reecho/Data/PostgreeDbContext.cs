
namespace Reecho.Data;

public class PostgreeDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public PostgreeDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public DbSet<Vynil> Vynils { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgreSQL"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreeDbContext).Assembly);
    }
}