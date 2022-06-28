using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.LeaveTypes.Commands.Create;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand,long>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        _mapper = mapper;
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<long> Handle(CreateLeaveTypeCommand command, CancellationToken cancellationToken)
    {
        var leaveType =_mapper.Map<LeaveType>(command.LeaveTypeDto);

        leaveType = await _leaveTypeRepository.AddAsync(leaveType);
        return leaveType.Id;
    }
}