using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CarService
{
    public class CarRepository : ICarRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;


        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteCar(string id)
            => _context.Cars.Remove(GetById(id));

        public IEnumerable<Car> GetAllCars()
            => _context.Cars.ToList();

        public Car GetById(string id)
            => _context.Cars.Find(id);

        public void InsertCar(Car car)
            => _context.Cars.Add(car);

        public void Save()
            => _context.SaveChanges();

        public void UpdateCar(Car car)
            => _context.Entry(car).State = EntityState.Modified;
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
