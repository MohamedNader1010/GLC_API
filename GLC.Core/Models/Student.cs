using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public int Email { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int parcode { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string ImageFile { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "This field is required.")]

        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(55)]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string ParentEmail { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int Level { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Gender { get; set; }
        [ForeignKey("Group")]
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }
        public ICollection<StudentQuize> studentQuizes { get; set; }
        public virtual ChatingDetails ChatingDetail { set; get; }

    }
}
