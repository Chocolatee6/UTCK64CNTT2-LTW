using System.Diagnostics;
using BTTH3.Models;
using BTTH3.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BTTH3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStoreRepository _repo;

        // Constructor mới nhận thêm Repository
        public HomeController(ILogger<HomeController> logger, IStoreRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // Action Index - Truyền dữ liệu sang View
        public IActionResult Index()
        {
            var vm = new HomeIndexVM
            {
                Categories = _repo.GetCategories(),
                LatestProducts = _repo.GetProducts()
                                      .OrderByDescending(p => p.CreatedAt)
                                      .Take(8)
                                      .ToList()
            };
            return View(vm);
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
