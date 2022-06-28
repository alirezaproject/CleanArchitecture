using Application.Features.LeaveAllocations.DTOs;
using Application.Features.LeaveRequests.Queries.GetDetail;
using Application.Features.LeaveRequests.Queries.GetList;
using Application.Features.LeaveTypes.DTOs;
using AutoMapper;
using Domain;

namespace Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
    }
}