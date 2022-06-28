using Application.Features.LeaveAllocations.DTOs;
using MediatR;

namespace Application.Features.LeaveAllocations.Queries.GetDetail;

public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
{
    public long Id { get; set; }

}