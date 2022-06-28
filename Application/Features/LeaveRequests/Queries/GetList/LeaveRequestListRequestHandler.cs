using Application.Features.LeaveRequests.Queries.GetDetail;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveRequests.Queries.GetList;

public class LeaveRequestListRequestHandler : IRequestHandler<LeaveRequestListRequest, List<LeaveRequestDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveRequestRepository _leaveRequestRepository;

    public LeaveRequestListRequestHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
    {
        _mapper = mapper;
        _leaveRequestRepository = leaveRequestRepository;
    }

    public async Task<List<LeaveRequestDto>> Handle(LeaveRequestListRequest request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<LeaveRequestDto>>(await _leaveRequestRepository.GetLeaveRequestWithDetails());
    }
}