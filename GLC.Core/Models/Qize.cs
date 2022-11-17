using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class Quize
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public int Mark { get; set; }
        public string Date { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        
        public ICollection<QuizeQuestion> QuizeQuestions { get; set; }
    }
}
