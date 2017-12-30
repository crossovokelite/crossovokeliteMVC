using crossovokeliteMVC.Models;
using System.Data.Entity;

namespace crossovokeliteMVC.Data
{
    public class RcrdDatabase : DbContext
    {
        public RcrdDatabase(): base("RcrdConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Rcrd> Rcrds { get; set; }
    }
}