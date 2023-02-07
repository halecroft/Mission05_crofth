using Microsoft.AspNetCore.Mvc;

namespace Mission05_crofth.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator ()
        {
            return View();
        }
    }
}
