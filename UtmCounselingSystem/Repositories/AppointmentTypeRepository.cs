using UtmCounselingSystem.Contracts;
using UtmCounselingSystem.Data;

namespace UtmCounselingSystem.Repositories
{
    public class AppointmentTypeRepository : GenericRepository<AppointmentType>, IAppointmentTypeRepository
    {
        public AppointmentTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
