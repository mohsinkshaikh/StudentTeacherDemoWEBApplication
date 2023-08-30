using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string CountryName { get; set; }

        public List<State> states { get; set; }
    }
}
