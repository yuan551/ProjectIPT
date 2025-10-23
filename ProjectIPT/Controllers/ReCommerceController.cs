using Microsoft.AspNetCore.Mvc;

namespace ProjectIPT.Controllers
{
    public class ReCommerceController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Registration()
        {
            return View("Registration");
        }

        public IActionResult Message()
        {
            return View("Message");
        }
    }
}
