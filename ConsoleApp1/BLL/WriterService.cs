using BLL.Interface;
using ProjectDb.Model;
using Repositories.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class WriterService : IWriterService
    {
        private readonly IUnitOfWork _uow;

        public WriterService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public List<Writer> GetAll()
        {
            return _uow.WriterRepository.ReadAll().ToList();
        }

        public Writer GetById(int id)
        {
            return _uow.WriterRepository.Read(id);
        }

        public Writer UpdateWriter(Writer _writer)
        {
            var _updatedWriter = _uow.WriterRepository.Update(_writer);
            _uow.SaveChanges();
            return _updatedWriter;
        }

        public void CreateWriter(Writer _writer)
        {
            _uow.WriterRepository.Create(_writer);
            _uow.SaveChanges();
        }

        public void DeleteWriter(Writer _writer)
        {
            _uow.WriterRepository.Delete(_writer);
            _uow.SaveChanges();
        }
    }
}
