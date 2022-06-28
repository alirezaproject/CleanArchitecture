using Domain;

namespace Application.Persistence.Contracts;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationWithDetails(long id);
    Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
}