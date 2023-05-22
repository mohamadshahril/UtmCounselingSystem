using System.ComponentModel.DataAnnotations.Schema;

namespace UtmCounselingSystem.Data
{
    public class AppointmentAllocation : BaseEntity
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        [ForeignKey("AppointmentTypeId")]
        public AppointmentType AppointmentType { get; set; }
        public int AppointmentTypeId { get; set; }
        public string ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
