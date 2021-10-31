using ProjectDb;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class GenericRepository<T>: IGenericRepository<T>
        where T : class
    {
        protected readonly ProjectDbContext _context;
        public GenericRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public T Create(T entity)
        {
            return _context.Add<T>(entity).Entity;
        }
        public T Read(int id)
        {
            return _context.Find<T>(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return _context.Set<T>();
        }

        public T Update(T entity)
        {
            return _context.Update<T>(entity).Entity;
        }

        public virtual void Delete(T entity) //виртуал, можем переопределить
        {
            _context.Remove<T>(entity);
        }
    }
}
