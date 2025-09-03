using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreMVCLab3.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string image {  get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }


        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book() {
                Id = 1,
                Title = "Mọi Nỗ Lực Và Chờ Đợi Của Bạn Đều Có Ý Nghĩa ",
                AuthorId = 1,
                GenreId = 1,
                image = "/images/products/p1.jpg",
                Price = 500000,
                Sumary = " ", TotalPage = 250
                },

                new Book()
                {
                    Id = 2,
                    Title = "Khó Khăn Như Chăn Mèo",
                    AuthorId = 2,
                    GenreId = 2,
                    image = "/images/products/p2.jpg",
                    Price = 125000,
                    Sumary = " ", TotalPage = 300
                },
                new Book()
                {
                    Id = 3,
                    Title = "Toán Học Khắp Quanh Ta - Tất Tật Về Phân Số",
                    AuthorId = 3,
                    GenreId = 3,
                    image = "/images/products/p3.jpg",
                    Price = 36000,
                    Sumary = " ", TotalPage = 350
                },
                new Book()
                {
                    Id = 4,
                    Title = "Toán Học Khắp Quanh Ta - Vận May Nào Cho Ta",
                    AuthorId = 4,
                    GenreId = 4,
                    image = "/images/products/p4.jpg",
                    Price = 18000,
                    Sumary = " ", TotalPage = 400
                },
            };

        return books;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b=>b.Id==id);
            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value = "1", Text = " Tac gia 1"},
            new SelectListItem{Value = "2", Text = " Tac gia 2"},
            new SelectListItem{Value = "3", Text = " Tac gia 3"},
            new SelectListItem{Value = "4", Text = " Tac gia 4"}
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem> {
            new SelectListItem{Value = "1",Text = "Phan Loai 1 " },
            new SelectListItem{Value = "2",Text = "Phan Loai 2 " },
            new SelectListItem{Value = "3",Text = "Phan Loai 3" },
            new SelectListItem{Value = "4",Text = "Phan Loai 4" }
        };


    }

    
}
