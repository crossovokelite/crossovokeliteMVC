using System;

namespace crossovokeliteMVC.Data
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IRcrdRepository Rcrds { get; }

        int SaveChanges();
    }
}