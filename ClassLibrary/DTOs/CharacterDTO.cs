namespace ClassLibrary.DTOs
{
    // DTO = what the frontend is allowed to see
    // No DB attributes
    // No EF Core references
    public class CharacterDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
    }
}
