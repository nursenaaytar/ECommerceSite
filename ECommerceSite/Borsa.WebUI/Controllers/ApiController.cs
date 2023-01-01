using Borsa.Business.Abstract;
using Borsa.DataAccess.Concrete.EfCore;
using Borsa.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Borsa.WebUI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiController : Controller
    {
        BorsaContext _context = new BorsaContext();
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ApiController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public JsonResult ProductsAndPrices()
        {
            var entity = _productService.ApiGetProductAndPrices();
            return Json(entity) ;
        }

        [HttpGet("{min}/{max}")]
        public JsonResult ProductsAndPricesWithParameters(int min, int max)
        {
            var entity = _productService.ApiGetProductAndPricesWithParameters(min,max);
            return Json(entity);
        }

        [HttpGet]
        public JsonResult ProductsStock()
        {
            var entity = _productService.ApiGetProductStock();
            return Json(entity); 
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            var message = "";
            using (var context = new BorsaContext())
            {
                var y1 = context.Categories.FirstOrDefault(x => x.Id == id);
                if (y1 is null)
                {
                    message = "Kategori bulunamadı!";
                }
                var y2 = context.ProductCategory.FirstOrDefault(x => x.CategoryId == id);
                if(y2 is not null)
                {
                    message = "Kategoriye bağlı ürünler var, kategori silinemez.";
                }
                if(message=="")
                {
                    context.Categories.Remove(y1);
                    context.SaveChanges();
                    message = "Başarılı";
                }             
                return  Json(message);
            }
             
        }
        
    }
}
