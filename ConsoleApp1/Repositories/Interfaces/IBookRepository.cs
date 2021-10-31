using ProjectDb.Model;
using System.Linq;

namespace Repositories.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        IQueryable<Book> ReadAllByYear(int year);
    }
}
