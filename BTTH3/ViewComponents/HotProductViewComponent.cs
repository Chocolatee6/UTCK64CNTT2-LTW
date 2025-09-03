using BTTH3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BTTH3.ViewComponents
{
    // Tên hiển thị của component sẽ là "HotProduct"
    public class HotProductViewComponent : ViewComponent
    {
        private readonly IStoreRepository _repo;

        public HotProductViewComponent(IStoreRepository repo)
        {
            _repo = repo;
        }

        // Có thể truyền tham số take từ View (mặc định 8)
        public IViewComponentResult Invoke(int take = 8)
        {
            var items = _repo.GetProducts()
                             .Where(p => p.IsHot)
                             .OrderByDescending(p => p.CreatedAt)
                             .Take(take)
                             .ToList();

            // Sẽ tìm view tại: Views/Shared/Components/HotProduct/Default.cshtml
            return View(items);
        }
    }
}
