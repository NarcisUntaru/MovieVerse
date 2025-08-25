using MovieVerse.Server.Data;
using MovieVerse.Server.Models;
using MovieVerse.Server.Repositories.Interfaces;

namespace MovieVerse.Server.Repositories
{
    public class CastRepository : GenericRepository<Cast>, ICastRepository
    {
        public CastRepository(MovieVerseServerContext dbContext) : base(dbContext) { }
    }
}
