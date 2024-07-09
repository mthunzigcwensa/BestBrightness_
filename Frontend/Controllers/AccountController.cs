using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string returnUrl = null)
        {

            returnUrl ??= Url.Content("~/");

            return View();
        }

        public IActionResult Register(string returnUrl = null)
        {

            returnUrl ??= Url.Content("~/");

            return View();
        }
    }
}
