using beer_timer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace beer_timer.Controllers
{
  
    public class HomeController : Controller
    {

        List<BeerTimer> _items;

        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
           _items = new List<BeerTimer>()
            {
                new BeerTimer (12, 34)
            };
            _context = context;
        }

        public IActionResult Timer()
        {
            return View(_items);
        }

        public IActionResult Index()
        {
            return View();
        }

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