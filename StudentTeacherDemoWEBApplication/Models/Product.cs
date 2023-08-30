using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string ProductName { get; set; }

        
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        [ValidateNever]
        public Category category { get; set; }  
    }
}
