using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CountryService
{
    public interface ICountryRepository : IDisposable
    {
        IEnumerable<Country> GetAllCountry();
        Country GetById(string id);
        void InsertCountry(Country country);
        void DeleteCountry(string id);
        void UpdateCountry(Country country);
        void Save();
    }
}
