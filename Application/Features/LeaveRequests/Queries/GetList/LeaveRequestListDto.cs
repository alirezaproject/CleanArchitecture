using Application.Features.LeaveTypes.DTOs;
using Common;

namespace Application.Features.LeaveRequests.Queries.GetList;

public class LeaveRequestListDto : BaseDto
{
    public LeaveTypeDto LeaveType { get; set; } = null!;
    public DateTime DateRequested { get; set; }
    public bool? Approved { get; set; }
}