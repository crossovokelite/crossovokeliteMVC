using crossovokeliteMVC.Models;
using System.Data.Entity;

namespace crossovokeliteMVC.Data
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context, bool sharedContext) : base(context, sharedContext) { }

        public User GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

        public User GetBy(string username)
        {
            return Find(u => u.UserName == username);

        }
    }
}