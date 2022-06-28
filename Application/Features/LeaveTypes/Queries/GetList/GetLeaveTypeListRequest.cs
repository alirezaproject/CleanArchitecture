using Application.Features.LeaveTypes.DTOs;
using MediatR;

namespace Application.Features.LeaveTypes.Queries.GetList;

public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
{

}