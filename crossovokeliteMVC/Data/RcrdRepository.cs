using crossovokeliteMVC.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace crossovokeliteMVC.Data
{
    public class RcrdRepository : EfRepository<Rcrd>, IRcrdRepository
    {
        public RcrdRepository(DbContext context, bool sharedContext)
            : base(context, sharedContext) { }

        public Rcrd GetBy(int id)
        {
            return Find(r => r.Id == id);
        }

        public IEnumerable<Rcrd> GetFor(User user)
        {
            return user.Rcrds.OrderByDescending(r => r.DateCreated);
        }

        public void AddFor(Rcrd rcrd, User user)
        {
            user.Rcrds.Add(rcrd);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }
    }
}