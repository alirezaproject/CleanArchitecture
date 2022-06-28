using Common;

namespace Application.Features.LeaveRequests.Commands.Update;

public class UpdateLeaveRequestDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveTypeId { get; set; }
    public string RequestComments { get; set; } = null!;
    public bool Cancelled { get; set; }
}