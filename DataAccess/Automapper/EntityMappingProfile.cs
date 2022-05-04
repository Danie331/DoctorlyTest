using AutoMapper;
using Domain = SchedulerDomainModels;
using Data = DataAccess.Entities;
using System.Linq;

namespace DataAccess.Automapper
{
   public  class EntityMappingProfile : Profile
    {
        public EntityMappingProfile()
        {
            CreateDomainToEntityMappings();
            CreateEntityToDomainMappings();
        }

        private void CreateDomainToEntityMappings()
        {
            CreateMap<Domain.Attendee, Data.Attendee>();
            CreateMap<Domain.Attendee, Data.EventAttendee>()
                .ForMember(s => s.AttendeeId, g => g.MapFrom(h => h.Id))
                .ForMember(s => s.Id, g => g.Ignore()); // This is not 100% correct approach

            CreateMap<Domain.Event, Data.Event>();
        }

        private void CreateEntityToDomainMappings()
        {
            CreateMap<Data.Attendee, Domain.Attendee>();
            CreateMap<Data.Event, Domain.Event>();
        }
    }
}