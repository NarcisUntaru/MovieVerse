using MovieVerse.Server.Data;
using MovieVerse.Server.Models;
using MovieVerse.Server.Repositories.Interfaces;

namespace MovieVerse.Server.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MovieVerseServerContext dbContext) : base(dbContext) { }
    }
}
