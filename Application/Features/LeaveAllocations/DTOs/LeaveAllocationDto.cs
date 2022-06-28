using Application.Features.LeaveTypes.DTOs;
using Common;

namespace Application.Features.LeaveAllocations.DTOs;

public class LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public LeaveTypeDto LeaveType { get; set; } = null!;
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}