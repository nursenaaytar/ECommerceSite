using Microsoft.AspNetCore.Mvc;

namespace ECommerceSite.Controllers
{
    public class AdminMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
