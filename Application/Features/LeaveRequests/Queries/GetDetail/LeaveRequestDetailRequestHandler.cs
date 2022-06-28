using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveRequests.Queries.GetDetail;

public class LeaveRequestDetailRequestHandler : IRequestHandler<LeaveRequestDetailRequest, LeaveRequestDto>
{
    private readonly IMapper _mapper;
    private readonly ILeaveRequestRepository _leaveRequestRepository;

    public LeaveRequestDetailRequestHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
    {
        _mapper = mapper;
        _leaveRequestRepository = leaveRequestRepository;
    }

    public async Task<LeaveRequestDto> Handle(LeaveRequestDetailRequest request, CancellationToken cancellationToken)
    {
        return _mapper.Map<LeaveRequestDto>(await _leaveRequestRepository.GetLeaveRequestWithDetails(request.Id));
    }
}