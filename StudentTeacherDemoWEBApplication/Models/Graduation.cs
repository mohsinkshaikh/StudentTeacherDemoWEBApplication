using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class Graduation
    {
        [Key]
        public int GradID { get; set; }

        [Required]
        public string GradName { get; set; }
       public List<PostGraduation> PostGraduations { get; set; }
    }
}
