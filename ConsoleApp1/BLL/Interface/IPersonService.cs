using ProjectDb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IPersonService
    {
        public List<Person> GetAll();
        public Person GetById(int _id);
        public Person UpdatePerson(Person _person);
        public void CreatePerson(Person _person);
        public void DeletePerson(Person _person);
       
    }
}
