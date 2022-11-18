using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int Level { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public  Teacher Teacher { get; set; }
        public ICollection<Video> videos { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Quize> Quizes { get; set; }            
    }
}
