using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class Courses
    {
        [Key]
        public int CourseID{ get; set; }
        [Required]
        [Display(Name = "Course Name")]
    //    [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string CourseName { get; set; }
        [Required]
        [Display(Name = "Course Code")]
        public string CourseCode{ get; set; }
       
        [Required]
        [Display(Name = "Course Fee")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public int CourseFee { get; set; }

        public ICollection<StudentCourse> StudCourse { get; set; }=new HashSet<StudentCourse>();
    }
}
