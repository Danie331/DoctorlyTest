
using AutoMapper;
using SchedulerDomainModels;

namespace SchedulingService.Automapper
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<ModelDto.AttendeeDto, Attendee>().ReverseMap();
            CreateMap<ModelDto.EventDto, Event>().ReverseMap();
        }
    }
}
