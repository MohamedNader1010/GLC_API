using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class Group
    {
        [Key]
        public int Id{ get; set; }
        public string Day{ get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int NumOfStudents { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public bool Availability { get; set; }
       public ICollection<Student> Students { get; set; }
    }
}
