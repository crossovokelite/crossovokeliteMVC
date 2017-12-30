using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace crossovokeliteMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }

        public int UserProfileId { get; set; }

        [ForeignKey("UserProfileId")]
        public virtual UserProfile Profile { get; set; }
        private ICollection<Rcrd> _rcrds;
        public virtual ICollection<Rcrd> Rcrds
        {
            get { return _rcrds ?? (_rcrds = new Collection<Rcrd>()); }
            set { _rcrds = value; }
        }
    }
}