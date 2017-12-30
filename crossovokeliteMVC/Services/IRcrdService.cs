using crossovokeliteMVC.Models;
using System;
using System.Collections.Generic;

namespace crossovokeliteMVC.Services
{
    namespace crossovokeliteMVC.Services
    {
        public interface IRcrdService
        {
            Rcrd GetBy(int id);
            Rcrd Create(int userId, string status, DateTime? created = null);
            Rcrd Create(User user, string status, DateTime? created = null);
            IEnumerable<Rcrd> GetTimelineFor(int userId);
        }
    }
}