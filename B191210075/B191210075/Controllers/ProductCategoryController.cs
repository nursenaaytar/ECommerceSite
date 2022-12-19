using Microsoft.AspNetCore.Mvc;
using ECommerceSite.Models;
namespace ECommerceSite.Controllers
{
    public class ProductCategoryController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.ProductCategory.ToList();
            return View(degerler);
        }
    }
}
