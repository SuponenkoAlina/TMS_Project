using ProjectDb;
using ProjectDb.Model;
using Repositories.Interfaces;

namespace Repositories
{
    public class WriterRepository : GenericRepository<Writer>, IWriterRepository
    {
        public WriterRepository(ProjectDbContext context) : base(context) { }

        public override void Delete(Writer writer)
        {
            writer.IsDeleted = true;
            _context.Update(writer);
        }
    }
}
