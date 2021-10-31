using ProjectDb;
using ProjectDb.Model;
using Repositories.Interfaces;
using System.Linq;

namespace Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ProjectDbContext context) : base(context) { }

        public IQueryable<Book> ReadAllByYear(int year)
        {
            return _context.Set<Book>().Where(book => book.Year == year);
        }
        public override void Delete(Book book)
        {
            book.IsDeleted = true;
            _context.Update(book);
        }
    }
}
