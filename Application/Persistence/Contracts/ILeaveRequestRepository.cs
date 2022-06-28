using Domain;

namespace Application.Persistence.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetails(long id);
    Task<List<LeaveRequest>> GetLeaveRequestWithDetails();

    Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approvedStatus);
}