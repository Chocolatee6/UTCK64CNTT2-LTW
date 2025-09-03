using System.Collections.Generic;

namespace BTTH3.Models.ViewModels
{
    public class HomeIndexVM
    {
        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();
        public IEnumerable<Product> LatestProducts { get; set; } = Enumerable.Empty<Product>();
    }
}
