using ClassLibrary.DTOs;
using Microsoft.EntityFrameworkCore;

public class CharacterService
{
    private readonly AppDbContext _db;

    public CharacterService(AppDbContext db)
    {
        _db = db;
    }

    // Service returns DTOs, NOT entities
    public async Task<List<CharacterDTO>> GetCharactersAsync()
    {
        // 1️⃣ Pull entities from DB
        var entities = await _db.Characters.ToListAsync();

        // 2️⃣ Map entities → DTOs
        // (Manual mapping for clarity; AutoMapper can come later)
        return entities.Select(e => new CharacterDTO
        {
            Id = e.Id,
            Name = e.Name,
            Class = e.Class,
            Level = e.Level,
            Health = e.Health,
            Mana = e.Mana
        }).ToList();
    }
}




// ----------------------OLD WAY WITHOUT EF CORE----------------
//private readonly IConfiguration _configuration;

//public HeroService(IConfiguration configuration)
//{
//    _configuration = configuration;
//}

//public async Task<List<Hero>> GetHeroesAsync()
//{
//    var heroes = new List<Hero>();
//    var connString = _configuration.GetConnectionString("DefaultConnection");

//    await using var conn = new NpgsqlConnection(connString);
//    await conn.OpenAsync();

//    var sql = "SELECT hero_id, name, class, level, health, mana, created_at FROM character;";

//    await using var cmd = new NpgsqlCommand(sql, conn);
//    await using var reader = await cmd.ExecuteReaderAsync();

//    while (await reader.ReadAsync())
//    {
//        heroes.Add(new Hero
//        {
//            HeroId = reader.GetGuid(0),
//            Name = reader.GetString(1),
//            Class = reader.GetString(2),
//            Level = reader.GetInt32(3),
//            Health = reader.GetInt32(4),
//            Mana = reader.GetInt32(5),
//            CreatedAt = reader.GetDateTime(6)
//        });
//    }

//    return heroes;
//}

