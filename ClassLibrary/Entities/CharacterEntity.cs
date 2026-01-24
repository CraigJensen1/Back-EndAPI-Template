using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Entities
{
    [Table("character")] // Match your PostgreSQL table
    public class CharacterEntity
    {
        [Key]               // EF Core now knows this is the PK
        [Column("hero_id")] // match your DB column
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("class")]
        public string Class { get; set; }

        [Column("level")]
        public int Level { get; set; }

        [Column("health")]
        public int Health { get; set; }

        [Column("mana")]
        public int Mana { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
