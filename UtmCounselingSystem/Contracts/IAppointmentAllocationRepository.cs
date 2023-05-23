using UtmCounselingSystem.Data;

namespace UtmCounselingSystem.Contracts
{
    public interface IAppointmentAllocationRepository : IGenericRepository<AppointmentAllocation>
    {
        Task AppointmentAllocaton(int appointmentTypeId);
        Task<bool> AllocationExist(string employeeId, int appointmentTypeId, int period);
    }
}
