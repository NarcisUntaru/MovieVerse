using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public required string Title { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int SeriesId { get; set; }
        public Series Series { get; set; }
    }
}
