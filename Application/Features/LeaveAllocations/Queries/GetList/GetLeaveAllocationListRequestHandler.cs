using Application.Features.LeaveAllocations.DTOs;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveAllocations.Queries.GetList;

public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<LeaveAllocationDto>>(await _leaveAllocationRepository.GetLeaveAllocationWithDetails());
    }
}