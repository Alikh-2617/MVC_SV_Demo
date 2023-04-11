using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.PeopleService
{
    public interface IPersonRepository : IDisposable /*IGenericService<Person>*/
    {
        IEnumerable<Person> GetAllPerson();
        Person GetById(int id);
        void InsertPerson(Person person);   
        void UpdatePerson(Person person);
        void DeletePerson(int id);
        void Save();

    }
}
