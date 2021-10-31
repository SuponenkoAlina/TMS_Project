using ProjectDb.Model;
using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IWriterService
    {
        public List<Writer> GetAll();
        public Writer GetById(int _id);
        public Writer UpdateWriter(Writer _writer);
        public void CreateWriter(Writer _writer);
        public void DeleteWriter(Writer _writer);
    }
}
