using Application.Features.LeaveAllocations.DTOs;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveAllocations.Queries.GetDetail;

public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
    {
        return _mapper.Map<LeaveAllocationDto>(await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id));
    }
}