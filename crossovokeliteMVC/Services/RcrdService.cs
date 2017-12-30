using crossovokeliteMVC.Data;
using crossovokeliteMVC.Models;
using crossovokeliteMVC.Services.crossovokeliteMVC.Services;
using System;
using System.Collections.Generic;

namespace crossovokeliteMVC.Services
{
    public class RcrdService : IRcrdService
    {
        private readonly IContext _context;
        private readonly IRcrdRepository _rcrds;

        public RcrdService(IContext context)
        {
            _context = context;
            _rcrds = context.Rcrds;
        }

        public Rcrd GetBy(int id)
        {
            return _rcrds.GetBy(id);
        }

        public Rcrd Create(User user, string status, DateTime? created = null)
        {
            var rcrd = new Rcrd()
            {
                Status = status,
                DateCreated = created.HasValue ? created.Value : DateTime.Now

            };

            _rcrds.AddFor(rcrd, user);

            _context.SaveChanges();

            return rcrd;
        }

        public Rcrd Create(int userId, string status, DateTime? created = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rcrd> GetTimelineFor(int userId)
        {
            throw new NotImplementedException();
        }
    }
}