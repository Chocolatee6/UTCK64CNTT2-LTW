namespace BTTH3.Models
{
    public interface IStoreRepository
    {
        IReadOnlyList<Category> GetCategories();
        IReadOnlyList<Product> GetProducts();
    }

    public class FakeStoreRepository : IStoreRepository
    {
        private readonly List<Category> _categories;
        private readonly List<Product> _products;

        public FakeStoreRepository()
        {
            _categories = new List<Category>
            {
                new Category{ Id=1, Name="Áo thun"},
                new Category{ Id=2, Name="Áo khoác"},
                new Category{ Id=3, Name="Túi xách"},
                new Category{ Id=4, Name="Đồng hồ"},
                new Category{ Id=5, Name="Ví & bóp"},
                new Category{ Id=6, Name="Giày dép"},
                new Category{ Id=7, Name="Thiết bị gia dụng"},
                new Category{ Id=8, Name="Bếp & nồi"},
                new Category{ Id=9, Name="Quạt điện"},
            };

            // ảnh placeholder: https://via.placeholder.com/300x220
            _products = Enumerable.Range(1, 20).Select(i => new Product
            {
                Id = i,
                Name = $"Nồi cơm điện cao tần Nagakawa NAG{i:000}",
                Price = 2250000 + i * 10000,
                ImageUrl = "https://via.placeholder.com/300x220",
                IsHot = i % 3 == 0, // cứ 3 sp thì là hot
                CreatedAt = DateTime.UtcNow.AddDays(-i),
                CategoryId = 8
            }).ToList();
        }

        public IReadOnlyList<Category> GetCategories() => _categories;
        public IReadOnlyList<Product> GetProducts() => _products;
    }
}
