using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class State
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string StateName { get; set; }

        public int CountryID { get; set; }

        public Country country { get; set; }

        public List<City> cities { get; set; }
    }
}
