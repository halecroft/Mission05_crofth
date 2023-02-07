using Microsoft.AspNetCore.Mvc;
using Mission05_crofth.Models;

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
        public IActionResult Calculator (CalculatorModel model)
        {
            return View();
        }
    }
}
