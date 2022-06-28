using Application.Features.LeaveTypes.DTOs;
using MediatR;

namespace Application.Features.LeaveTypes.Commands.Create;

public class CreateLeaveTypeCommand : IRequest<long>
{
    public CreateLeaveTypeDto LeaveTypeDto { get; set; }

}