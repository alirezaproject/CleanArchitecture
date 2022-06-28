using Common;

namespace Application.Features.LeaveAllocations.Commands.Update;

public class UpdateLeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}