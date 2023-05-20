using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UtmCounselingSystem.Models
{
    public class AppointmentTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Appointment Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
    }
}
