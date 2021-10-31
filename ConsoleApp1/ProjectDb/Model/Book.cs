using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDb.Model
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BookId { get; set; }
        
        [Required]
        public string Title { get; set; }
       
        [Required]
        public int Year { get; set; }

        [Required]
        public Genre Genre { get; set; }
        
        [Required]
        public string Country { get; set; }
        public DateTime DateOfAdd { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<AudioBook> AudioBooks { get; set; }
        public virtual ICollection<Writer> Writers { get; set; }
        //public virtual ICollection<Genre> Genres { get; set; }
    }
}