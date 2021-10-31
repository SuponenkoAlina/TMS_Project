using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDb.Model
{
    [Serializable]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(15)]
        [Required]
        public string Login { get; set; }

        [MaxLength(20)]
        [Required]
        public string Password { get; set; }

        [MaxLength(10)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }
        //public int Rating { get; set; }
        //public string Review { get; set; }
        //public bool IsDeleted { get; set; }
        //public DateTime HireDate { get; set; }

        //public virtual ICollection<Genre> Genre { get; set; }

        //todo add ratings+

        //todo add orders 
    
        //todo movie(game? ...) reference 
    }
}
