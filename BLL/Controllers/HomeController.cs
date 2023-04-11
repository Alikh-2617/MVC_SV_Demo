using DAL.Repository;
using DAL.Repository.PeopleService;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace BLL.Controllers
{
    [Route("/api/people")]
    public class HomeController : Controller
    {
        private IPersonRepository _repo;

        public HomeController(IPersonRepository userRepository)
        {
            _repo = userRepository;
        }
        [HttpGet]
        [Route("list")]
        public IList<Person> Index()
        {
            return (List<Person>)_repo.GetAllPerson();
        }
    }
}
