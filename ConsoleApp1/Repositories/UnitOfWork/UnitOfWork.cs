using ProjectDb;
using ProjectDb.Model;
using Repositories.Interfaces;
using System;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public readonly ProjectDbContext _context;
        public UnitOfWork(ProjectDbContext context)
        {
            _context = context;
        }


        public GenericRepository<AudioBook> AudioBookRepository =>  new Lazy<GenericRepository<AudioBook>>(() => new GenericRepository<AudioBook>(_context)).Value;


        public BlogRepository BlogRepository => new Lazy<BlogRepository>(() => new BlogRepository(_context)).Value;


        
        public GenericRepository<Rating> RatingRepository =>  new Lazy<GenericRepository<Rating>>(() => new GenericRepository<Rating>(_context)).Value;



        //public GenericRepository<Genre> GenreRepository =>  new Lazy<GenericRepository<Genre>>(() => new GenericRepository<Genre>(_context)).Value;


       
        public PersonRepository PersonRepository =>  new Lazy<PersonRepository>(() => new PersonRepository(_context)).Value;


        
        public WriterRepository WriterRepository => new Lazy<WriterRepository>(() => new WriterRepository(_context)).Value;


        
        public IBookRepository BookRepository =>  new Lazy<BookRepository>(() => new BookRepository(_context)).Value;

       

        public IGenericRepository<T> GetGenericRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
