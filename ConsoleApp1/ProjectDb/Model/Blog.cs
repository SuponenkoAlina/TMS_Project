using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectDb.Model
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string WriterName { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("WriterId")]
        public virtual Writer Writer { get; set; }
        public virtual ICollection<Recording> Recordings { get; set; }

       
    }
}
