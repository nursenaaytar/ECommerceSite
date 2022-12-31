using Borsa.Business.Abstract;
using Borsa.DataAccess.Concrete.EfCore;
using Borsa.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<Product> ProductsAndPrices()
        {
            var entity = _productService.ApiGetProductAndPrices();
            return entity;
        }

        [HttpGet("{min}/{max}")]
        public IEnumerable<Product> ProductsAndPricesWithParameters(int min, int max)
        {
            var entity = _productService.ApiGetProductAndPricesWithParameters(min,max);
            return entity;
        }
    }
}
