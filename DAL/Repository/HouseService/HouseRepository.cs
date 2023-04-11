using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.HouseService
{
    public class HouseRepository : IHouseRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;


        public HouseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteHouse(int id)
            =>_context.Houses.Remove(GetById(id));    

        public IEnumerable<House> GetAllHouse()
            =>_context.Houses.ToList();

        public House GetById(int id)
            => _context.Houses.Find(id);

        public void InsertHouse(House house)
            =>_context.Houses.Add(house);   

        public void Save()
            =>_context.SaveChanges();

        public void UpdateHouse(House house)
            =>_context.Entry(house).State = EntityState.Modified;
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
