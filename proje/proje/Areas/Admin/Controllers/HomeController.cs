using Microsoft.AspNetCore.Mvc;

namespace proje.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
