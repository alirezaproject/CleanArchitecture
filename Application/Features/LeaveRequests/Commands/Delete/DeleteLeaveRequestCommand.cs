using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveRequests.Commands.Delete;

public class DeleteLeaveRequestCommand : IRequest
{
    public long Id { get; set; }

}

public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
{
    private readonly IMapper _mapper;
    private readonly ILeaveRequestRepository _leaveRequestRepository;

    public DeleteLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
    {
        _mapper = mapper;
        _leaveRequestRepository = leaveRequestRepository;
    }

    public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        await _leaveRequestRepository.Delete(request.Id);

        return Unit.Value;
    }
}
