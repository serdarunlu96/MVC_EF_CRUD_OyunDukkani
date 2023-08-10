using Microsoft.AspNetCore.Mvc;
using OyunDukkani.Data;
using OyunDukkani.Models;
using System.Diagnostics;

namespace OyunDukkani.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OyunlarContext db;
        public HomeController(ILogger<HomeController> logger, OyunlarContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.oyunlar.ToList());
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