using ProjectDb;
using ProjectDb.Model;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(ProjectDbContext context) : base(context) { }

        public override void Delete(Blog blog)
        {
            blog.IsDeleted = true;
            _context.Update(blog);
        }
    }
}
