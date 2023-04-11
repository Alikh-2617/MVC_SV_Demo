using DAL.DataCantext;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UnitOfWork /*: IDisposable*/
    {
        //private bool disposed = false;
        //private ApplicationDbContext _context;
        //private GenericService<Person> _personService;
        //private GenericService<Job> _jobService;
        //private GenericService<Car> _carService;
        //private GenericService<City> _cityService;
        //private GenericService<Continent> _continentService;
        //private GenericService<Country> _countryService;
        //private GenericService<House> _houseService;


        //public UnitOfWork(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        //public GenericService<House> HouseRepo
        //{
        //    get
        //    {
        //        if (_houseService == null)
        //        {
        //            _houseService = new GenericService<House>(_context);
        //        }
        //        return _houseService;
        //    }
        //}

        //public GenericService<Country> CountryRepo
        //{
        //    get
        //    {
        //        if (_countryService == null)
        //        {
        //            _countryService = new GenericService<Country>(_context);
        //        }
        //        return _countryService;
        //    }
        //}

        //public GenericService<Continent> ContinentRepo
        //{
        //    get
        //    {
        //        if (_continentService == null)
        //        {
        //            _continentService = new GenericService<Continent>(_context);
        //        }
        //        return _continentService;
        //    }
        //}
        //public GenericService<City> CityRepo
        //{
        //    get
        //    {
        //        if (_cityService == null)
        //        {
        //            _cityService = new GenericService<City>(_context);
        //        }
        //        return _cityService;
        //    }
        //}
        //public GenericService<Car> CarRepo
        //{
        //    get
        //    {
        //        if (_carService == null)
        //        {
        //            _carService = new GenericService<Car>(_context);
        //        }
        //        return _carService;
        //    }
        //}
        //public GenericService<Person> PersonRepo
        //{
        //    get
        //    {
        //        if (_personService == null)
        //        {
        //            _personService = new GenericService<Person>(_context);
        //        }
        //        return _personService; 
        //    }
        //}
        //public GenericService<Job> JobRepo
        //{
        //    get
        //    {
        //        if (_jobService == null)
        //        {
        //            _jobService = new GenericService<Job>(_context);
        //        }
        //        return _jobService;
        //    }
        //}
        //public void Save()
        //{
        //    _context.SaveChanges();
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
