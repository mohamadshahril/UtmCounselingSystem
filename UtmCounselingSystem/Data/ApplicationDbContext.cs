using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UtmCounselingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<AppointmentAllocation> AppointmentAllocations { get; set; }
    }
}