using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDb.Model
{
    public class AudioBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Language { get; set; }
        public DateTime Duration { get; set; }

        //todo store a file 

        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
