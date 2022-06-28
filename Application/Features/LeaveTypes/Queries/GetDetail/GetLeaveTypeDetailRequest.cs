using Application.Features.LeaveTypes.DTOs;
using MediatR;

namespace Application.Features.LeaveTypes.Queries.GetDetail;

public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
{
    public long Id { get; set; }
}