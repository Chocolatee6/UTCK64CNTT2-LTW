using Microsoft.AspNetCore.Mvc;

namespace BT4.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Dashboard";
            ViewBag.Active = "dashboard";
            return View();
        }
    }
}
