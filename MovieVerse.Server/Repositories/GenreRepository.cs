using MovieVerse.Server.Data;
using MovieVerse.Server.Models;
using MovieVerse.Server.Repositories.Interfaces;

namespace MovieVerse.Server.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieVerseServerContext dbContext) : base(dbContext) { }
    }
}
