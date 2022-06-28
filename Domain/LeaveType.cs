using Common;

namespace Domain;

public class LeaveType : BaseDomainEntity
{
    public string Name { get; set; } = null!;
    public int DefaultDays { get; set; }
}