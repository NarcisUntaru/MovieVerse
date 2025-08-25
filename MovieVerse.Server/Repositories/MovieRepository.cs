using MovieVerse.Server.Data;
using MovieVerse.Server.Models;
using MovieVerse.Server.Repositories.Interfaces;

namespace MovieVerse.Server.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieVerseServerContext dbContext) : base(dbContext) { }
    }
}
