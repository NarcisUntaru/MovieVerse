namespace MovieVerse.Server.Models
{
    public class Cast
    {
        public int CastId { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int? MovieId { get; set; }
        public Movie Movie { get; set; }

        public int? SeriesId { get; set; }
        public Series Series { get; set; }

        public string Role { get; set; }
    }
}
