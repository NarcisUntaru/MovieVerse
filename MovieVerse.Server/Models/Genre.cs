using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public required string Name { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<Series> Series { get; set; } = new List<Series>();
    }
}
