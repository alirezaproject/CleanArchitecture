using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveRequests.Commands.Update;

public class UpdateLeaveRequestCommand : IRequest<Unit>
{
    public long Id { get; set; }
    public UpdateLeaveRequestDto UpdateLeaveRequestDto { get; set; }

    public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set; }


}

public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;

    public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
    {

        var leaveRequest = await _leaveRequestRepository.GetAsync(request.Id);
        if (request.UpdateLeaveRequestDto != null)
        {


            _mapper.Map(request.UpdateLeaveRequestDto, leaveRequest);

            await _leaveRequestRepository.UpdateAsync(leaveRequest);

        }

        else if (request.ChangeLeaveRequestApprovalDto != null)
        {
         
            await _leaveRequestRepository.ChangeApprovalStatus(leaveRequest,request.ChangeLeaveRequestApprovalDto.Approved);
            
        }


        return Unit.Value;

    }
}

