using System.ComponentModel.DataAnnotations;

namespace GLC.Cores.Models
{
    public class ChatingDetails
    {
        public int StId { get; set; }
        public int GroupChatId { get; set; }
        public int GroupId { get; set; }
        public int TeacherId { get; set; }
    }
}
