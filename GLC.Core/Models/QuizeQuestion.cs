using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class QuizeQuestion
    {
        [ForeignKey("Quize")]
        public int QuizeId { get; set; }
        public virtual Quize Quize { get; set; }
        public int QuestionID { get; set; }
        [ForeignKey("Question")]
        public int BankId { get; set; }
        public virtual QuestionBank Question { get; set; }


    }
}
