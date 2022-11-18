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
        [ForeignKey("Quiz")]
        public int StudentId { get; set; }
        public Quize Quiz { get; set; }
        [ForeignKey("Subject")]
        public int SubjectID { get; set; }
        public  Subject Subject { get; set; }
        public ICollection<StudentQuizeQuestionBank> QuizeQuestions { get; set; }
    }
}
