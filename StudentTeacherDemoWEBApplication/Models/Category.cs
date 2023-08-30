using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
