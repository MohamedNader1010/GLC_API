using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class QuestionCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Category { get; set; }
        [ForeignKey("QuestionBank")]
        [Required]
        public int QuestionBankId { get; set; }
        public virtual QuestionBank QuestionBank { get; set; }
    }
}
