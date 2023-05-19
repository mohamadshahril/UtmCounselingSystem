using System.ComponentModel.DataAnnotations.Schema;

namespace UtmCounselingSystem.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
