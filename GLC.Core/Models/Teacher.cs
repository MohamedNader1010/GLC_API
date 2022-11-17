using System.ComponentModel.DataAnnotations;

namespace GLC.Cores.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }
        public string Password { get; set; }
        public  string Phone { get; set; }  
        public string School { get; set; }
        public string PhotoPath { get; set; }
        public ICollection<Subject> subjects{ get; set; }
        public ICollection<Video> videos { get; set; }
    }
}
