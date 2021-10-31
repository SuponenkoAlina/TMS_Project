using BLL.Interface;
using System;
using System.Collections.Generic;
using Repositories.Interfaces;
using ProjectDb.Model;
using System.Linq;
using Repositories.UnitOfWork;

namespace BLL
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _uow;
        public BookService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Delete(Book _book)
        {
            _uow.BookRepository.Delete(_book);
        }

        public List<Book> GetAll()
        {
            return _uow.BookRepository.ReadAll().ToList();
        }

        public List<Book> GetByGenre(Enum _genre)
        {
            List<Book> _byGenre = (List<Book>)_uow.BookRepository.ReadAll().Where(g => g.Genre.Equals(_genre));
            return _byGenre;
        }

        public Book GetById(int id)
        {
            return _uow.BookRepository.Read(id);
        }

        public List<Book> GetByParameters(string _author, string _name)
        {
            var _booksList = _uow.BookRepository.ReadAll().Where(b => b.Title == _name);
            var _book = _booksList.Where(b => b.Writers.Any(w => w.LastName == _author));
            return _book.ToList();
        }

        public List<Book> GetNewSix()
        {
            //var _firstAll = _uow.BookRepository.ReadAll();
            //List<Book> _firstSix;

            //return _firstAll;
            throw new NotImplementedException();
        }

        public List<Book> GetFirstSixByRating()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetNew()
        {
            return
             _uow.BookRepository
                .ReadAll()
                .Where(u => u.Year == DateTime.Now.Year)
                .ToList();
        }
        public Book Update(Book book)
        {
            _uow.
               BookRepository.
               Update(book);
            _uow.SaveChanges();
            return book;
        }
    }
}
