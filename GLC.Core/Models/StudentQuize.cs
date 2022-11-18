using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class StudentQuize
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [ForeignKey("Quize")]
        public int QuizeId { get; set; }
        public virtual Quize Quize { get; set; }
        
        public  string StudentAnswer { get; set; }


    }
}
