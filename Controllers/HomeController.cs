using System.Diagnostics;
using CTSTempDataDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CTSTempDataDemo.Controllers
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
            TempData["names"] = new List<string>() { "Mano", "Mahim", "Malar" };
            TempData.Keep("names");
            return View();
        }

        public IActionResult Privacy()
        {
           
            ViewBag.nms = TempData["names"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
