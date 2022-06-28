using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.LeaveAllocations.Commands.Create;

public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, long>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<long> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = _mapper.Map<LeaveAllocation>(request.CreateLeaveAllocationDto);

        leaveAllocation = await _leaveAllocationRepository.AddAsync(leaveAllocation);

        return leaveAllocation.Id;
    }
}