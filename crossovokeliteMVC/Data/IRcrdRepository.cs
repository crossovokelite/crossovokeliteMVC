using crossovokeliteMVC.Models;
using System.Collections.Generic;

namespace crossovokeliteMVC.Data
{
    public interface IRcrdRepository : IRepository<Rcrd>
    {
        Rcrd GetBy(int id);
        IEnumerable<Rcrd> GetFor(User user);
        void AddFor(Rcrd rcrd, User user);
    }
}