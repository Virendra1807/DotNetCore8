using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
