using System;

namespace crossovokeliteMVC.Data
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IEagletRepository Eaglets { get; }

        int SaveChanges();
    }
}