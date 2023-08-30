using Microsoft.AspNetCore.Mvc.Rendering;
using StudentTeacherDemoWEBApplication.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentTeacherDemoWEBApplication.ViewModel
{
    public class StudentCourseViewModel
    {
        [Key]
        public int STUD_ID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers are allowed.")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Gender Radio")]
        public string GenderRadio { get; set; }
        [Required]
        [Display(Name = "Gender Enum")]
        public string GenderEnum { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string Taluka { get; set; }
        [Required]
        public DateTime Enrolled { get; set; }
        [Required]
        public string ImagePath { get; set; }

        [NotMapped]
        [Display(Name = "Upload Image")]
        public IFormFile ImageProfile { get; set; }
        public Gender Gender { get; set; }

        public IList<SelectListItem> Courses { get; set; }
    }
}
