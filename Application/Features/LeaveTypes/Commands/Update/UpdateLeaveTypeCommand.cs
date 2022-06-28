using Application.Features.LeaveTypes.DTOs;
using MediatR;

namespace Application.Features.LeaveTypes.Commands.Update;

public class UpdateLeaveTypeCommand : IRequest<Unit>
{
    public LeaveTypeDto LeaveTypeDto { get; set; }

}