using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public required string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public int StudioId { get; set; }
        public Studio Studio { get; set; }

        public ICollection<Cast> Casts { get; set; } = new List<Cast>();
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public ICollection<Award> Awards { get; set; } = new List<Award>();
    }
}
