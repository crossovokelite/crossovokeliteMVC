using System.Data.Entity;

namespace crossovokeliteMVC.Data
{
    public class Context : IContext
    {
        private readonly DbContext _db;

        public Context(DbContext context = null, IUserRepository users = null,
            IEagletRepository rcrds = null)
        {
            _db = context ?? new EagletDatabase();
            Users = users ?? new UserRepository(_db, true);
            Eaglets = rcrds ?? new EagletRepository(_db, true);
        }

        public IUserRepository Users
        {
            get;
            private set;
        }

        public IEagletRepository Eaglets
        {
            get;
            private set;
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                try
                {
                    _db.Dispose();
                }
                catch { }
            }
        }
    }
}