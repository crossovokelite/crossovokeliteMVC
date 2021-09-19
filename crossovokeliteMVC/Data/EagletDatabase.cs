using crossovokeliteMVC.Models;
using System.Data.Entity;

namespace crossovokeliteMVC.Data
{
    public class EagletDatabase : DbContext
    {
        public EagletDatabase() : base("RcrdConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Eaglet> Eaglets { get; set; }
    }
}