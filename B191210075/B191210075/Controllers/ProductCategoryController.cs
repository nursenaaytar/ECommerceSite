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
        [HttpGet]
        public IActionResult NewProductCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewProductCategory(ProductCategoryViewModel p)
        {
            c.ProductCategory.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");          
        }

        public IActionResult DeleteProductCategory(int id)
        {
            var pc=c.ProductCategory.Find(id);
            c.ProductCategory.Remove(pc);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetProductCategory(int id)
        {
            var pc = c.ProductCategory.Find(id);
            return View(GetProductCategory);
        }

        public IActionResult UpdateProductCategory(int id)
        {
            return View();
        }
    }
}
