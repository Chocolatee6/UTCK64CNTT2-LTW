using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TheSecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Demo(string name)
        {
            return Content($"Xin chào {name ?? "bạn"} !");
        }

    }
}
