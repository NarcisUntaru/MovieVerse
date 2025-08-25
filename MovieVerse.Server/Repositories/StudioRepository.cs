using MovieVerse.Server.Data;
using MovieVerse.Server.Models;
using MovieVerse.Server.Repositories.Interfaces;

namespace MovieVerse.Server.Repositories
{
    public class StudioRepository : GenericRepository<Studio>, IStudioRepository
    {
        public StudioRepository(MovieVerseServerContext dbContext) : base(dbContext) { }
    }
}
