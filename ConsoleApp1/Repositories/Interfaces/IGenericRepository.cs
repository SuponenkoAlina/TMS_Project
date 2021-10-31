using System.Collections.Generic;
using System.Linq;

namespace Repositories.Interfaces
{
    public interface IGenericRepository<T>
        where T : class
    {
        public T Create(T entity);
        public T Read(int id);
        public IEnumerable<T> ReadAll();
        public T Update(T entity);
        void Delete(T entity);
    }
}
