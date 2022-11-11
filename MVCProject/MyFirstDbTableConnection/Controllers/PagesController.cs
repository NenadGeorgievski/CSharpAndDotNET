using Microsoft.AspNetCore.Mvc;
using MyFirstDbTableConnection.Data;
using MyFirstDbTableConnection.Models.Entity;

namespace MyFirstDbTableConnection.Controllers
{
    public class PagesController : Controller
    {
        public PagesController(BookstoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public BookstoreDbContext dbContext { get; set; }
        public IActionResult OurTeam()
        {
            IEnumerable<Employee> ListOfEmployees = dbContext.Employees;
            return View(ListOfEmployees);
        }
    }
}
