using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "This field is required.")]

        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "This field is required.")]

        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Phone { get; set; } 
        [Required(ErrorMessage = "This field is required.")]
        public string School { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string PhotoPath { get; set; }
        public  ChatingDetails ChatingDetails { get; set; }
        public ICollection<Subject> subjects { get; set; } = new Collection<Subject>();
        public ICollection<Video> videos { get; set; } = new Collection<Video>();
    }
}
