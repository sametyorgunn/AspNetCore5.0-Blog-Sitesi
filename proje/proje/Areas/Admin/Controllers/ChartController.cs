using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using proje.Areas.Admin.Models;
using System.Collections.Generic;

namespace proje.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
           
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                CategoryName = "Teknoloji",
                CategoryCount = 10
                
            });
            list.Add(new CategoryClass
            {
                CategoryName = "Yazılım",
                CategoryCount = 14

            });
            list.Add(new CategoryClass
            {
                CategoryName = "Spor",
                CategoryCount = 5

            });
            return Json(new { jsonlist = list });
        }
    }
}
