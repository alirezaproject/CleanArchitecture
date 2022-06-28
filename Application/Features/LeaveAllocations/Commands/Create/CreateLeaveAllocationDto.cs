using Common;

namespace Application.Features.LeaveAllocations.Commands.Create;

public class CreateLeaveAllocationDto 
{
    public int NumberOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}