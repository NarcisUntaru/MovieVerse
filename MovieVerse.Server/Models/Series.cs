using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Series
    {
        public int SeriesId { get; set; }
        public required string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public int StudioId { get; set; }
        public Studio Studio { get; set; }

        public ICollection<Episode> Episodes { get; set; } = new List<Episode>();
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public ICollection<Cast> Casts { get; set; } = new List<Cast>();
        public ICollection<Award> Awards { get; set; } = new List<Award>();
    }
}
