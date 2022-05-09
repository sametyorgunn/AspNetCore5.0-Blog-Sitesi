using Microsoft.AspNetCore.Mvc;

namespace proje.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1()
        {
            return View();
        }
    }
}
