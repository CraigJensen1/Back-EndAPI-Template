
// DTO - Data Transfer Object matches the UI needs, not the database exactly
namespace ClassLibrary.DTOs;

public class CharacterDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
}
