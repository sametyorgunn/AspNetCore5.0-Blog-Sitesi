using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace proje.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentmanager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = commentmanager.GetCommentWithBlog();
            return View(values);
        }
    }
}
