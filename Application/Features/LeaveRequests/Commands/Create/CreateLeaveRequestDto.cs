using Common;

namespace Application.Features.LeaveRequests.Commands.Create;

public class CreateLeaveRequestDto 
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveTypeId { get; set; }
    public string RequestComments { get; set; } = null!;
}