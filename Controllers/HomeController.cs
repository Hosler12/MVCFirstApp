using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string ID)
        {
            if (ID == "cit")
                return View("cit218");
            else
                return View();
        }

        public IActionResult cit218()
        {
            return View();
        }

        //Get: Home
        public string myIndex()
        {
            return " YourFirtName's Awesome Index";
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