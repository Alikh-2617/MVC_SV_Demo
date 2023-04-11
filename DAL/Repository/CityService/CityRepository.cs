using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CityService
{
    public class CityRepository : ICityRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteCity(string id)
            =>_context.cities.Remove(GetById(id));  

        public IEnumerable<City> GetAllCity()
            =>_context.cities.ToList();

        public City GetById(string id)
            => _context.cities.Find(id);

        public void InsertCity(City city)
            => _context.cities.Add(city);

        public void Save()
            => _context.SaveChanges();

        public void UpdateCity(City city)
            =>_context.Entry(city).State = EntityState.Modified;

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
