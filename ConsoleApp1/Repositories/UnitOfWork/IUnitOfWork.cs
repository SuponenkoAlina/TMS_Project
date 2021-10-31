using ProjectDb.Model;
using Repositories.Interfaces;

namespace Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<AudioBook> AudioBookRepository { get; }
        BlogRepository BlogRepository { get; }
        GenericRepository<Rating> RatingRepository { get; }
        //GenericRepository<Genre> GenreRepository { get; }
        PersonRepository PersonRepository { get; }
        WriterRepository WriterRepository { get; }
        IBookRepository BookRepository { get; }
        IGenericRepository<T> GetGenericRepository<T>() where T : class;
        void SaveChanges();
    }
}
