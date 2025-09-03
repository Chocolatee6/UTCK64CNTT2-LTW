﻿using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab3.Models;
namespace NetCoreMVCLab3.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book ();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres=book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
    }
}
