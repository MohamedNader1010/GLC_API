using System.ComponentModel.DataAnnotations;

namespace GLC.Cores.Models
{
    public class QuestionBank
    {
        [Key]
        public int Id { get; set; }
        public int QuestionMark { get; set; }
        public int Level { get; set; }

    }
}
