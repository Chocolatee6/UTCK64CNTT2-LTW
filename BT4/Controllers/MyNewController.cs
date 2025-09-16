using Microsoft.AspNetCore.Mvc;

namespace BT4.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
