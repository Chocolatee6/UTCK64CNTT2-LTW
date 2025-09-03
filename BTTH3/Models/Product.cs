namespace BTTH3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = ""; // có thể dùng ảnh placeholder
        public bool IsHot { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CategoryId { get; set; }
    }
}
