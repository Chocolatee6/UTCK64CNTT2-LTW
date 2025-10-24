using System.Diagnostics;
using hqa_231230703_de01.Models;
using Microsoft.AspNetCore.Mvc;

namespace hqa_231230703_de01.Controllers
{
    public class HqaHomeController : Controller
    {
        private readonly ILogger<HqaHomeController> _logger;

        public HqaHomeController(ILogger<HqaHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HqaIndex()
        {
            return View();
        }

        public IActionResult HqaPrivacy()
        {
            return View();
        }

        public IActionResult HqaContact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
