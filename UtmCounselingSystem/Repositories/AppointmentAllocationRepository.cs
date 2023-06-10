using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UtmCounselingSystem.Constants;
using UtmCounselingSystem.Contracts;
using UtmCounselingSystem.Data;

namespace UtmCounselingSystem.Repositories
{
    public class AppointmentAllocationRepository : GenericRepository<AppointmentAllocation>, IAppointmentAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Client> userManager;
        private readonly IAppointmentTypeRepository appointmentTypeRepository;
        private readonly IMapper mapper;
        public AppointmentAllocationRepository(ApplicationDbContext context, 
            UserManager<Client> userManager, IAppointmentTypeRepository appointmentTypeRepository) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.appointmentTypeRepository = appointmentTypeRepository;
        }

        public async Task<bool> AllocationExist(string clientId, int appointmentTypeId, int period)
        {
            return await context.AppointmentAllocations.AnyAsync(q => q.ClientId == clientId 
            && q.AppointmentTypeId == appointmentTypeId && q.Period == period);
        }

        public async Task AppointmentAllocation(int appointmentTypeId)
        {
            var clients = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var appointmentType = await appointmentTypeRepository.GetAsync(appointmentTypeId);
            var allocations = new List<AppointmentAllocation>();

            foreach (var client in clients)
            {
                if (await AllocationExist(client.Id, appointmentTypeId, period))
                    continue;
                allocations.Add(new AppointmentAllocation
                {
                    ClientId = client.Id,
                    AppointmentTypeId = appointmentTypeId,
                    Period = period,
                    NumberOfDays = appointmentType.DefaultDays
                });
            }

            await AddRangeAsync(allocations);
        }

        public Task AppointmentAllocaton(int appointmentTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
