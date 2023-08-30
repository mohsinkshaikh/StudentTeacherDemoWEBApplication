using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class PostGraduation
    {
        [Key]
        public int PostID { get; set; }

        [Required]
        public string PostName { get; set; }

        [Required]
        [ForeignKey("tbl_graduation")]
        public int GradID { get; set; }
        public List<Graduation> graduation {get; set;}        
    }
}
