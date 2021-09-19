using crossovokeliteMVC.Models;
using System.Collections.Generic;

namespace crossovokeliteMVC.Data
{
    public interface IEagletRepository : IRepository<Eaglet>
    {
        Eaglet GetBy(int id);
        IEnumerable<Eaglet> GetFor(User user);
        void AddFor(Eaglet eaglet, User user);
    }
}