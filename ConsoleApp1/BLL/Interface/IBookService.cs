using ProjectDb.Model;
using System;
using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IBookService
    {
        public List<Book> GetByParameters(string _author, string _name);
        public List<Book> GetNewSix();
        public List<Book> GetFirstSixByRating();
        public List<Book> GetByGenre(Enum _genre);
        public List<Book> GetNew();
        public Book GetById(int _id);
        List<Book> GetAll();
        public Book Update(Book _book);

        public void Delete(Book _book);
    }
}