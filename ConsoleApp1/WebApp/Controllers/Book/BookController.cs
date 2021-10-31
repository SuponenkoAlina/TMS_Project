using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;


namespace WebApp.Controllers.Book
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService _bookService)
        {
            this._bookService = _bookService;
        }

        [HttpPost]
        public IActionResult UpdateBook(BookInfo info)
        {
            var _book = _bookService.GetById(info.BookId);

            _book.Genre = info.Genre;//1 sec
            _book.Country = info.Country;
            _book.Rating = info.Rating;

            _bookService.Update(_book);

            return Redirect(Url.Action("GetAll", "Book"));
            
            //return Json(new
            //{
            //    isDeleted = _person.IsDeleted,
            //    newData = new { success = "Успешно" },
            //    deletedTextMessage = new { yes = "Да", no = "Нет" }
            //});

            //return Json(new{ success = "Operator is Unhire!!!"});
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookService.GetAll().ToList();

            var model = new List<BookInfo>();

            foreach (var item in books)
            {
                model.Add(new BookInfo {
                
                BookId = item.BookId,
                Genre = item.Genre,
                Title = item.Title,
                //Writers = item.Writers,
                Year = item.Year
                });
            }

            //model = books.Select(o => new BookInfo
            //{
            //    BookId = o.BookId,
            //    Genre = o.Genre,
            //    Country = o.Country,
            //    Rating = o.Rating

            //}).ToList();

            return PartialView(model);
        }

        [HttpGet]
        public IActionResult GetAll(string bookname)
        {
            var books = _bookService.GetAll().ToList().Where(b => b.Title.Contains(bookname));

            var model = new List<BookInfo>();

            foreach (var item in books)
            {
                model.Add(new BookInfo
                {

                    BookId = item.BookId,
                    Genre = item.Genre,
                    Title = item.Title,
                    //Writers = item.Writers,
                    Year = item.Year
                });
            }

            //model = books.Select(o => new BookInfo
            //{
            //    BookId = o.BookId,
            //    Genre = o.Genre,
            //    Country = o.Country,
            //    Rating = o.Rating

            //}).ToList();

            return PartialView(model);
        }






        [HttpGet]
        public IActionResult GetFullInfo(int id)
        {
            var _book = _bookService.GetById(id);

            var model = new BookInfo
            {
                BookId = _book.BookId,
                Genre = _book.Genre,
                Country = _book.Country,
                Rating = _book.Rating
                
            };

            return View(model);

        }

        //[HttpPost]
        //public IActionResult Delete(Book _book)
        //{
        //    _bookService.Delete(_book);
        //    return RedirectToAction("GetAll", "Book");
        //}

    }
}
