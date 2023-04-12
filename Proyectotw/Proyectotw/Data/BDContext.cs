using Microsoft.AspNetCore.Mvc;

namespace Proyectotw.Data
{
    public class BDContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
