using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CountryService
{
    public class CountryRepository : ICountryRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context; 
        }
        public void DeleteCountry(string id)
            => _context.Countries.Remove(GetById(id));

        public IEnumerable<Country> GetAllCountry()
            =>_context.Countries.ToList();

        public Country GetById(string id)
            => _context.Countries.Find(id);

        public void InsertCountry(Country country)
            =>_context.Countries.Add(country);  

        public void Save()
            =>_context.SaveChanges();

        public void UpdateCountry(Country country)
            =>_context.Entry(country).State = EntityState.Modified;

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
