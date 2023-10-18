using Microsoft.AspNetCore.Mvc;
using SXUWebsite.Models;
using System.Diagnostics;

namespace SXUWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Skils()
        {
            return View();
        }

        public IActionResult Count()
        {
            return View();
        }
        public IActionResult Client()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Contact()
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