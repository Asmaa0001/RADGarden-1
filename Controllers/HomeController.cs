using Microsoft.AspNetCore.Mvc;

namespace RADGarden.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

