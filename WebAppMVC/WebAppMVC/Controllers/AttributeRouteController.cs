using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class AttributeRouteController : Controller
    {
        [Route("")] 
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            ViewData["Data1"] = "Viren Mali";
            ViewData["Data2"] = 23;
            ViewData["Data3"] = DateTime.Now.ToLongDateString();
             
            String[] arr = { "Viren", "Goku", "Mohan" };
            ViewData["Data4"] = arr;
            return View();
        }

        [Route("About")]
        [Route("About/Index")]
        public IActionResult About()
        {
            return View();
        }


        [Route("Details/{id?}")]
        public int Details(int? id) // Nullable handling
        {
            return id ?? 3129; // IF Null then Show 3129 
        }

        // We give any name to Action method but view should give our HTML View path in View() Mthod
        [Route("Payment")]
        public IActionResult PaymentActionMethod()
        { 
            return View("~/Views/AttributeRoute/Pay.cshtml");
        }


    }
}
