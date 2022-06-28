using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveTypes.Commands.Update;

public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public UpdateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.GetAsync(request.LeaveTypeDto.Id);

        _mapper.Map(request.LeaveTypeDto, leaveType);

        await _leaveTypeRepository.UpdateAsync(leaveType);
        
        return Unit.Value;
    }
}