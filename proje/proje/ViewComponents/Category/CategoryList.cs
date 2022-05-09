using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace proje.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager km = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = km.GetList();
            return View(values);
        }
    }
}
