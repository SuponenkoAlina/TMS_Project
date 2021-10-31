using ProjectDb.Model;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class WriterInfo
    {
       
        public int WriterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string Blog { get; set; }//??? Нужно-ли это поле? На 20-ой строке мы уже объявляем навигационное свойство, связывающее
                                        //писателя с коллекцией книг.
        public bool IsDeleted { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
