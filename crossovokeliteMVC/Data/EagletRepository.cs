using crossovokeliteMVC.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace crossovokeliteMVC.Data
{
    public class EagletRepository : EfRepository<Eaglet>, IEagletRepository
    {
        public EagletRepository(DbContext context, bool sharedContext)
            : base(context, sharedContext) { }

        public Eaglet GetBy(int id)
        {
            return Find(r => r.Id == id);
        }

        public IEnumerable<Eaglet> GetFor(User user)
        {
            return user.Eaglets.OrderByDescending(r => r.DateCreated);
        }

        public void AddFor(Eaglet rcrd, User user)
        {
            user.Eaglets.Add(rcrd);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }
    }
}