using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Entities
{
    // This class represents EXACTLY how the database table looks
    // It is NOT meant to be sent to the UI
    [Table("character")]
    public class CharacterEntity
    {
        [Key]
        [Column("hero_id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("class")]
        public string Class { get; set; } = string.Empty;

        [Column("level")]
        public int Level { get; set; }

        [Column("health")]
        public int Health { get; set; }

        [Column("mana")]
        public int Mana { get; set; }

        // Notice: this exists in the DB but NOT in the DTO
        // UI does not need it
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
