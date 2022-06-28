using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveAllocations.Commands.Update;

public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await _leaveAllocationRepository.GetAsync(request.UpdateLeaveAllocationDto.Id);

        _mapper.Map(request.UpdateLeaveAllocationDto,leaveAllocation);

        await _leaveAllocationRepository.UpdateAsync(leaveAllocation);
        return Unit.Value;
        
    }
}