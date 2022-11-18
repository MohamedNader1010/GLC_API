using System.ComponentModel.DataAnnotations;

namespace GLC.Cores.Models
{
    public class QuestionBank
    {
        [Key]
        public int Id { get; set; }
        public int QuestionMark { get; set; }
        public int Level { get; set; }
        [MaxLength(5)]
        public string CorrectAnswer { get; set; }   
        public virtual QuizeQuestion QuizeQuestion { get; set; }
        public ICollection <QuestionAnswer> QuestionAnswers { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }  
    }
}
