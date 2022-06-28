using MediatR;

namespace Application.Features.LeaveRequests.Commands.Create;

public class CreateLeaveRequestCommand : IRequest<long>
{
    public CreateLeaveRequestDto CreateLeaveRequestDto { get; set; }

}

