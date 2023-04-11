using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.HouseService
{
    public interface IHouseRepository : IDisposable
    {
        IEnumerable<House> GetAllHouse();
        House GetById(int id);
        void InsertHouse(House house);
        void DeleteHouse(int id);
        void UpdateHouse(House house);
        void Save();
    }
}
