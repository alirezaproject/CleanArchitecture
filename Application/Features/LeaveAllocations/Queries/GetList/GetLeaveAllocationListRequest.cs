using Application.Features.LeaveAllocations.DTOs;
using MediatR;

namespace Application.Features.LeaveAllocations.Queries.GetList;

public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
{

}