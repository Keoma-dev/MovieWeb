using Microsoft.AspNetCore.Mvc;

namespace MovieWeb.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Welcome(string name = "Vreemdeling", int numberOfTimes = 1)
        {
            ViewData["Name"] = name;
            ViewData["NumberOfTimes"] = numberOfTimes;
            return View();
        }

        public IActionResult Today()
        {
            return View();
        }
    }
}
