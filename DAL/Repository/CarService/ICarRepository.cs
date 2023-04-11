using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CarService
{
    public interface ICarRepository : IDisposable
    {
        IEnumerable<Car> GetAllCars();
        Car GetById(string id);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(string id);
        void Save();

    }
}
