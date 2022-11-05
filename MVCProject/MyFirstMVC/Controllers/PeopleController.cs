using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Data;
using MyFirstMVC.Models;
using MyFirstMVC.Models.Entities;

namespace MyFirstMVC.Controllers
{
    public class PeopleController : Controller
    {
        private FirstContext DbCon;

        public PeopleController(FirstContext dbCon)
        {
            DbCon = dbCon;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowPeople()
        {

            IEnumerable<Person> listOfPeople = DbCon.People;
            return View(listOfPeople);
        }
        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View(new Person()); 
        }

        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            DbCon.People.Add(person);
            DbCon.SaveChanges();

            return RedirectToAction(nameof(ShowPeople));
        }
    }
}
