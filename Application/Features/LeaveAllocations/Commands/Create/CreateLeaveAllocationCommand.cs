using MediatR;

namespace Application.Features.LeaveAllocations.Commands.Create;

public class CreateLeaveAllocationCommand : IRequest<long>
{
    public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; }
}