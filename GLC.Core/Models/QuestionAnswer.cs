using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{ 
    public class QuestionAnswer
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionAnsWer { get; set; }
        [ForeignKey("QuestionBank")]
        public int BankId { get; set; }
        public  QuestionBank QuestionBank { get; set; }
   
    }
}
