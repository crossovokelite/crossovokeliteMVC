using crossovokeliteMVC.Models;
using System;
using System.Collections.Generic;

namespace crossovokeliteMVC.Services
{
    namespace crossovokeliteMVC.Services
    {
        public interface IEagletService
        {
            Eaglet GetBy(int id);
            Eaglet Create(int userId, string status, DateTime? created = null);
            Eaglet Create(User user, string status, DateTime? created = null);
            IEnumerable<Eaglet> GetTimelineFor(int userId);
        }
    }
}