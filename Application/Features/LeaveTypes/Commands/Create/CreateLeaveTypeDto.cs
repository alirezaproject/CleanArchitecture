using Common;

namespace Application.Features.LeaveTypes.Commands.Create;

public class CreateLeaveTypeDto 
{
    public string Name { get; set; }
    public int DeafaultDays { get; set; }

}