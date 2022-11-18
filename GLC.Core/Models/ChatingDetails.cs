using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class ChatingDetails
    {
        [ForeignKey("Student")]
        public int StId { get; set; }
        public  Student Student { get; set; }
        [ForeignKey("GroupChat")]
        public int GroupChatId { get; set; }
        public  GroupChat GroupChat{ get; set; }
        public int GroupId { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public  Teacher Teacher { get; set; }
    }
}
