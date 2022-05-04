using AutoMapper;
using DataAccess.Entities;
using SchedulerDataContract;
using System.Threading.Tasks;
using Domain = SchedulerDomainModels;
using Data = DataAccess.Entities;
using System;

namespace DataAccess
{
    public class AttendeeRepository : IAttendeeRepository
    {
        private readonly IMapper _mapper;
        private readonly EventSchedulerContext _context;
        public AttendeeRepository(EventSchedulerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Domain.Attendee> AddAsync(Domain.Attendee attendee)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var insertAttendee = _mapper.Map<Data.Attendee>(attendee);
                    var insertAttendeeResult = await _context.Attendee.AddAsync(insertAttendee);
                    await _context.SaveChangesAsync();
                    var result = _mapper.Map<Data.Attendee, Domain.Attendee>(insertAttendeeResult.Entity);

                    var insertEventAttendee = _mapper.Map<Data.EventAttendee>(result);
                    insertEventAttendee.EventId = attendee.EventId;         // This is not the correct way to map related objects in EF Core but due to time pressure this will do for now.
                    result.EventId = attendee.EventId;          // This is not the correct way to map related objects in EF Core but due to time pressure this will do for now.
                    await _context.EventAttendee.AddAsync(insertEventAttendee);
                    await _context.SaveChangesAsync();

                    transaction.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    // Log exception for the repository layer
                    throw;
                }
            }
        }
    }
}
