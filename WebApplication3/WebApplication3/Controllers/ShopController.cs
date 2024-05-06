using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
