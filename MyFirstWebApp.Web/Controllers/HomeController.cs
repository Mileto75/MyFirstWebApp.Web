using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Web.Models;
using System.Diagnostics;

namespace MyFirstWebApp.Web.Controllers
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
        public IActionResult Info(int id)
        {
            //home/23/info
            return Content($"ProductId:{id}");
        }
        public IActionResult ProductInfo(int id)
        {
            return Content($"productInfo id:{id}", "text/html");
        }
       
        public IActionResult Goto()
        {
            return Redirect("https://www.gazzetta.it");
        }

        public IActionResult Lost()
        {
            return BadRequest();
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