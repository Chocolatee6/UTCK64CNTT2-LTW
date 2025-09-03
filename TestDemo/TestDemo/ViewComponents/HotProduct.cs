using Microsoft.AspNetCore.Mvc;
using TestDemo.Models;
namespace TestDemo.ViewComponents
{
    public class HotProduct : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var hp = new List<ProductModel>
            {
                new ProductModel { Name = "Product 1", ImgURL = "image/noicom.jpeg"},
                new ProductModel { Name = "Product 2", ImgURL = "image/noicom.jpeg"},
                new ProductModel { Name = "Product 3", ImgURL = "image/noicom.jpeg"},
                new ProductModel { Name = "Product 3", ImgURL = "image/noicom.jpeg"}
            };
            return View(hp);
        }
    }
}
