using Application.Features.LeaveRequests.Queries.GetDetail;
using MediatR;

namespace Application.Features.LeaveRequests.Queries.GetList;

public class LeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
{

}