using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace proje.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager mn = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AllNotification()
        {
            var values = mn.GetList();

            return View(values);
        }
    }
}
