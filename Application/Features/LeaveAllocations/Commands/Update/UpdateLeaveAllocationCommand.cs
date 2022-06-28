using MediatR;

namespace Application.Features.LeaveAllocations.Commands.Update;

public class UpdateLeaveAllocationCommand : IRequest<Unit>
{
    public UpdateLeaveAllocationDto UpdateLeaveAllocationDto { get; set; }
}