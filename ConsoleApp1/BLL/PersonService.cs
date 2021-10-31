using BLL.Interface;
using ProjectDb.Model;
using Repositories.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork _uow;
        public PersonService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public List<Person> GetAll()
        {
            return _uow.
                PersonRepository.
                ReadAll().ToList();
        }

        public Person GetById(int id)
        {
            return _uow.
                PersonRepository.
                Read(id);
        }

        public Person UpdatePerson(Person person)
        {
            _uow.
                PersonRepository.
                Update(person);
            _uow.SaveChanges();
            return person;
        }

        public void CreatePerson(Person _person)
        {
            _uow.PersonRepository.Create(_person);
            _uow.SaveChanges();
        }

        public void DeletePerson(Person _person)
        {
            _uow.PersonRepository.Delete(_person);
            _uow.SaveChanges();
        }
    }
}
