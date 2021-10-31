using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDb.Model
{
    public class Recording
    {
        [Key]
        public int RecordingId { get; set; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}
