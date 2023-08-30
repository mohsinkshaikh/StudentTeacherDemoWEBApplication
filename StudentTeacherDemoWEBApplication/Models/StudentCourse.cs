using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class StudentCourse
    {
        [Key]
        public int ID_SC { get; set; }    
        public Student Students { get; set; }
        public Courses Courses { get; set; }
    }
}
