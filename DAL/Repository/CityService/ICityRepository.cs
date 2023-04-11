using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CityService
{
    public interface ICityRepository : IDisposable
    {
        IEnumerable<City> GetAllCity();
        City GetById(string id);
        void InsertCity(City city);
        void DeleteCity(string id);
        void UpdateCity(City city);
        void Save();
    }
}
