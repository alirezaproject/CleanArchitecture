using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.LeaveRequests.Commands.Create;

public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, long>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;

    public CreateLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
    {
        _mapper = mapper;
        _leaveRequestRepository = leaveRequestRepository;
    }

    public async Task<long> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = _mapper.Map<LeaveRequest>(request.CreateLeaveRequestDto);

        leaveRequest = await _leaveRequestRepository.AddAsync(leaveRequest);

        return leaveRequest.Id;
    }
}