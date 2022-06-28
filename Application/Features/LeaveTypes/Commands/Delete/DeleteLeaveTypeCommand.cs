using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveTypes.Commands.Delete;

public class DeleteLeaveTypeCommand : IRequest
{
    public long Id { get; set; }

}

public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public DeleteLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        await _leaveTypeRepository.Delete(request.Id);

        return Unit.Value;
    }
}