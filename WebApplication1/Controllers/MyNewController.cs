using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Hoang Quoc Anh";
            ViewBag.Age = 20;
            TempData["Email"] = "hqanhh7605@gmai.com";
            return RedirectToAction("Sample");
        }
        public IActionResult Sample()
        {
            return View("Index"); // return ve action cua Index
           
        }

        public String Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
