using crossovokeliteMVC.Data;
using crossovokeliteMVC.Models;
using crossovokeliteMVC.Services.crossovokeliteMVC.Services;
using System;
using System.Collections.Generic;

namespace crossovokeliteMVC.Services
{
    public class EagletService : IEagletService
    {
        private readonly IContext _context;
        private readonly IEagletRepository _eaglets;

        public EagletService(IContext context)
        {
            _context = context;
            _eaglets = context.Eaglets;
        }

        public Eaglet GetBy(int id)
        {
            return _eaglets.GetBy(id);
        }

        public Eaglet Create(User user, string status, DateTime? created = null)
        {
            var rcrd = new Eaglet()
            {
                Status = status,
                DateCreated = created.HasValue ? created.Value : DateTime.Now

            };

            _eaglets.AddFor(rcrd, user);

            _context.SaveChanges();

            return rcrd;
        }

        public Eaglet Create(int userId, string status, DateTime? created = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Eaglet> GetTimelineFor(int userId)
        {
            throw new NotImplementedException();
        }
    }
}