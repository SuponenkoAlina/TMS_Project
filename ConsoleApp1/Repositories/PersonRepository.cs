using ProjectDb;
using ProjectDb.Model;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(ProjectDbContext context) : base(context) { }

        public override void Delete(Person person)
        {
            //person.IsDeleted = true;
            _context.Update(person);
        }
    }
}
