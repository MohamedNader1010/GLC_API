using System.ComponentModel.DataAnnotations;

namespace GLC.Cores.Models
{
    public class GroupChat
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public int level { get; set; }
        public ICollection<ChatingDetails> Chats { get; set; }

    }
}
