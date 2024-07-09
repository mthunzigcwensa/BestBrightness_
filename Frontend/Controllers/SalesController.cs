using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
