using System.ComponentModel.DataAnnotations;

namespace MovieVerse.Server.Models
{

    public class Award

    {

    public int AwardId { get; set; }
    public required string Name { get; set; }
    public required int Year { get; set; }

    public ICollection<Actor> Actors { get; set; } = new List<Actor>();
    public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    public ICollection<Series> Series { get; set; } = new List<Series>();

    }

}