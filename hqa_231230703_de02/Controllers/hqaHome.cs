using System.Diagnostics;
using hqa_231230703_de02.Models;
using Microsoft.AspNetCore.Mvc;

namespace hqa_231230703_de02.Controllers
{
    public class hqaHome : Controller
    {
        private readonly ILogger<hqaHome> _logger;

        public hqaHome(ILogger<hqaHome> logger)
        {
            _logger = logger;
        }

        public IActionResult hqaIndex()
        {
            return View();
        }

        public IActionResult hqaPrivacy()
        {
            return View();
        }
        public IActionResult hqaAbout()
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
