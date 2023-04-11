using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.PeopleService
{
    public class PersonRepository : IPersonRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;


        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetAllPerson() 
            => _context.People.ToList();

        public Person GetById(int id)
            => _context.People.Find(id);

        public void InsertPerson(Person person)
            =>_context.People.Add(person);

        public void UpdatePerson(Person person)
            => _context.Entry(person).State = EntityState.Modified; 

        public void Save()
            => _context.SaveChanges();

        public void DeletePerson(int id)
            => _context.People.Remove(GetById(id));

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
