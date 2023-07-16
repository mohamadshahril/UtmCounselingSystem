using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UtmCounselingSystem.Models
{
    public class BookAppointmentVM
    {
        [Display(Name = "UTM ID ")]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Name ")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string? Email { get; set; }


        [Display(Name = "Phone Number")]
        [Required]
        public int PhoneNumber { get; set; }

        [Display(Name = "Remark")]
        [Required]
        public string? Remark { get; set; }
    }
}
