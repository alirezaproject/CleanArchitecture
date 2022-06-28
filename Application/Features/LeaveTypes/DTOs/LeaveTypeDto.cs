using Common;

namespace Application.Features.LeaveTypes.DTOs;

public class LeaveTypeDto : BaseDto
{
    public string Name { get; set; } = null!;
    public int DefaultDays { get; set; }
}