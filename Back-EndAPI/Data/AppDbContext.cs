using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<CharacterEntity> characters => Set<CharacterEntity>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
