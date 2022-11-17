using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Email { get; set; }
        public int parcode { get; set; }
        public string ImageFile { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string ParentEmail { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public string Phone { get; set; }     
        public string Gender { get; set; }
        public ICollection<Quize> Quizes { get; set; }
        [ForeignKey("Group")]
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }
        

    }
}
