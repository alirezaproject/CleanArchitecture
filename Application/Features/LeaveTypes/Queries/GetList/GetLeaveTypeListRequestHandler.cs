using Application.Features.LeaveTypes.DTOs;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveTypes.Queries.GetList;

public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypes = await _leaveTypeRepository.GetAsync();
        return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
    }
}