using Application.Features.LeaveTypes.DTOs;

namespace Application.Features.LeaveRequests.Queries.GetDetail;

public class LeaveRequestDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveTypeDto LeaveType { get; set; } = null!;
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; } = null!;
    public DateTime? DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}