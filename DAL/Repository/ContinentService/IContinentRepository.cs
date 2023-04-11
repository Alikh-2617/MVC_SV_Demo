using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ContinentService
{
    public interface IContinentRepository : IDisposable
    {
        IEnumerable<Continent> GetAllContinent();
        Continent GetById(string id);
        void InsertContinent(Continent continent);
        void DeleteContinent(string id);
        void UpdateContinent(Continent continent);
        void Save();
    }
}
