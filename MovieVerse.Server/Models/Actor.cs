using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Cast> Casts { get; set; } = new List<Cast>();
        public ICollection<Award> Awards { get; set; } = new List<Award>();
    }
}
