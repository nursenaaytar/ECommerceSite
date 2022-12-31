using Borsa.DataAccess.Concrete.EfCore;
using Borsa.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Borsa.WebUI.Controllers
{
    [ApiController]
    public class ApiController : Controller
    {
        BorsaContext _context = new BorsaContext();

       //  [HttpGet]
        //public IEnumerable<Product> ProductsAndPrices()
        //{
        //    var productsAndPrices = /* from n in _context.Products.*/;
        //    return productsAndPrices.toList();
        //}
    }
}
