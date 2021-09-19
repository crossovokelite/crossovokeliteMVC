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
        private ICollection<Eaglet> _eaglets;
        public virtual ICollection<Eaglet> Eaglets
        {
            get { return _eaglets ?? (_eaglets = new Collection<Eaglet>()); }
            set { _eaglets = value; }
        }
    }
}