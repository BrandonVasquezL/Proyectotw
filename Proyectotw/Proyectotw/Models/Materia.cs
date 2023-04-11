using Microsoft.AspNetCore.Mvc;

namespace Proyectotw.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
