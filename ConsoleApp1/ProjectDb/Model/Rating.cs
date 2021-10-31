using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDb.Model
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RatingId { get; set; }
        public int Stars { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
