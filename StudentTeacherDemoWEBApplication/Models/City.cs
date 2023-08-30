using System.ComponentModel.DataAnnotations;

namespace StudentTeacherDemoWEBApplication.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CityName { get; set; }
        public int StateID { get; set; }
        public State state { get; set; }
    }
}
