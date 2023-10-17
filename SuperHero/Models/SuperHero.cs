using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHero.Models
{
    [Table("SuperHeroes")]
    public class SuperHeroModel
    {
        public int Id { get; set; }
        public string? Apodo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Lugar { get; set; }
    }
}
