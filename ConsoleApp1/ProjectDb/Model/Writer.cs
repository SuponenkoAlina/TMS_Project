using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDb.Model
{
    public class Writer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WriterId { get; set; }
        
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Biography { get; set; }
        
        public string Blog { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
