using MovieVerse.Server.Data;
using MovieVerse.Server.Models;
using MovieVerse.Server.Repositories.Interfaces;

namespace MovieVerse.Server.Repositories
{
    public class DirectorRepository : GenericRepository<Director>, IDirectorRepository
    {
        public DirectorRepository(MovieVerseServerContext dbContext) : base(dbContext) { }
    }
}
