using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // DbSet = a table
    // EF uses this to generate SQL
    public DbSet<CharacterEntity> Characters => Set<CharacterEntity>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
