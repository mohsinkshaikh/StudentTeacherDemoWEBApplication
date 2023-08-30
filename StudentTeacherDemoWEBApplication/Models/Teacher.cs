using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class Teacher
    {
        [Key]
        public int TID { get; set; }
        [Required]
        [Display(Name = "Teacher Name")]
      //  [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string TeacherName { get; set; }       
    }
}
 