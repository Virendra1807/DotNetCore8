using Microsoft.AspNetCore.Mvc;

namespace RoutingTypes.Controllers
{   
    public class Cart : Controller
    {
        public IActionResult CartView()
        {
            return View();
        }
        public int Details(int id)
        {
            return id; 
        }
    }
}
