using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Studio
    {
        public int StudioId { get; set; }
        public required string Name { get; set; }
        public string Location { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<Series> Series { get; set; } = new List<Series>();
    }
}
