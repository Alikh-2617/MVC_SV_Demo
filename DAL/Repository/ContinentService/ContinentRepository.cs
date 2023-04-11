using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ContinentService
{
    public class ContinentRepository : IContinentRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;

        public ContinentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteContinent(string id)
            => _context.Continents.Remove(GetById(id));

        public Continent GetById(string id)
            => _context.Continents.Find(id);

        public IEnumerable<Continent> GetAllContinent()
            => _context.Continents.ToList();

        public void InsertContinent(Continent continent)
            => _context.Continents.Add(continent);

        public void Save()
            => _context.SaveChanges();

        public void UpdateContinent(Continent continent)
            =>_context.Entry(continent).State = EntityState.Modified;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
