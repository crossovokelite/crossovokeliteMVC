using System.Data.Entity;

namespace crossovokeliteMVC.Data
{
    public class Context : IContext
    {
        private readonly DbContext _db;

        public Context(DbContext context = null, IUserRepository users = null, 
            IRcrdRepository rcrds = null)
        {
            _db = context ?? new RcrdDatabase();
            Users = users ?? new UserRepository(_db, true);
            Rcrds = rcrds ?? new RcrdRepository(_db, true);
        }

        public IUserRepository Users
        {
            get;
            private set;
        }

        public IRcrdRepository Rcrds
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