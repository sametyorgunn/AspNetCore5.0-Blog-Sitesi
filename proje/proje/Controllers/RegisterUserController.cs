using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using proje.Models;
using System.Threading.Tasks;

namespace proje.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;

        public RegisterUserController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Index(UserSignUpModel p)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.mail,
                    UserName = p.username,
                    namesurname = p.namesurname,


                };
                var result = await _usermanager.CreateAsync(user, p.password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
