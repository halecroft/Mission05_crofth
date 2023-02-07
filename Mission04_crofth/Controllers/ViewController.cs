using Microsoft.AspNetCore.Mvc;

namespace Mission05_crofth.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator (object model)
        {
            return View();
        }
    }
}
