using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<Series> Series { get; set; } = new List<Series>();
    }
}
