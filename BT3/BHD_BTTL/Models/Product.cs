namespace BHD_BTTL.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Name = "Nồi Cơm Điện Cao Tầng cuckko",
                    Image = "/images/products/m1.jpeg",
                },
                new Product()
                {
                    Name = "Nồi cơm điện hiện đại blueStone",
                    Image = "/images/products/noi com moi.jpg",
                },
                new Product()
                {
                    Name = "Nồi cơm điện GoldSun GRC5000",
                    Image = "/images/products/noi_com.webp",
                },
            };
            return products;
        }
    }
}
