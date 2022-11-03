using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Northwind.Mvc.Data;
using Northwind.Mvc.Models;

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindDbContext db;

        public HomeController(ILogger<HomeController> logger, NorthwindDbContext northwindDb)
        {
            _logger = logger;
            db = northwindDb;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel model = new
            (
                visitorCount: (new Random()).Next(1, 1001),
                categories: db.Categories.ToList(),
                products: db.Products.ToList()
            );

            return View(model);
        }
        [Route("Private")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}