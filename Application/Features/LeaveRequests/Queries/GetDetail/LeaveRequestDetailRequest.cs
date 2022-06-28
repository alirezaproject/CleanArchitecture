using MediatR;

namespace Application.Features.LeaveRequests.Queries.GetDetail;

public class LeaveRequestDetailRequest : IRequest<LeaveRequestDto>
{
    public long Id { get; set; }

}