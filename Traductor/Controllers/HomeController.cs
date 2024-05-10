using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Traductor.Models;

namespace Traductor.Controllers
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
            var traductorViewModel = new TraductorViewModel(); // Creas una instancia del ViewModel
            return View("index", traductorViewModel); // Pasas el ViewModel a la vista
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
