using Microsoft.AspNetCore.Mvc;

namespace CookieAuthDemo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
