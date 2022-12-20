using beer_timer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace beer_timer.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> RankingView()
        {
            var rankings = _context.Rankings.ToList();

            var ranks = from b in _context.Rankings
                       select b;
            ranks = ranks.OrderBy(x => x.Sec);
            return View(await ranks.AsNoTracking().ToListAsync());
        }



        public IActionResult Timer(int id)
        {
            var ranking = _context.Rankings
                .Find(id);
            ViewBag.ranking = ranking;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Timer([Bind("UserNameId,Sec,Tens,Technique")] Ranking ranking)
        {
            var rankingAdd = _context.Rankings.Find(ranking.UserNameId);
            if (ModelState.IsValid)
            {
                ViewBag.addedRanking = rankingAdd;

                _context.Rankings.Add(ranking);
                _context.SaveChanges();
                return View("PlacedRanking", ranking);
            }
            else
            {
                ViewBag.addedRanking = rankingAdd;
                return View(ranking);
            }
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