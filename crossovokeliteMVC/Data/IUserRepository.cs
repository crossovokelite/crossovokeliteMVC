using crossovokeliteMVC.Models;

namespace crossovokeliteMVC.Data
{
    public interface IUserRepository : IRepository<User>
    {
        User GetBy(int id);
        User GetBy(string username);
    }
}