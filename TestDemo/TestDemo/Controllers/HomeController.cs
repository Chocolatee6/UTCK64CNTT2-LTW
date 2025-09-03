using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestDemo.Models;

namespace TestDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var p = new List<ProductModel>
            {
                new ProductModel { Name = "Product 1", ImgURL = "image/noicom.jpeg"},
                new ProductModel { Name = "Product 2", ImgURL = "image/noicom.jpeg"},
                new ProductModel { Name = "Product 3", ImgURL = "image/noicom.jpeg"},
                new ProductModel { Name = "Product 3", ImgURL = "image/noicom.jpeg"}
            };
            return View(p);
        }

        public IActionResult Privacy()
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
