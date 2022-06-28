using Application.Persistence.Contracts;
using MediatR;

namespace Application.Features.LeaveAllocations.Commands.Delete;

public class DeleteLeaveAllocationCommand : IRequest
{
    public long Id { get; set; }
}

public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;

    public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
    }

    public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        await _leaveAllocationRepository.Delete(request.Id);

        return Unit.Value;
    }
}