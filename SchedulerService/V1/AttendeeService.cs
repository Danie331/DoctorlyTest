
using SchedulerDataContract;
using SchedulerDomainModels;
using SchedulerServiceContract;
using System;
using System.Threading.Tasks;

namespace SchedulerServices.V1
{
    public class AttendeeService : IAttendeeService
    {
        private readonly IAttendeeRepository _attendeeRepository;
        public AttendeeService(IAttendeeRepository attendeeRepository)
        {
            _attendeeRepository = attendeeRepository;
        }

        public async Task<Attendee> AddAsync(Attendee attendee)
        {
            try
            {
                var result = await _attendeeRepository.AddAsync(attendee);

                // Validation can optionally be performed here to ensure the result is a valid domain object
                return result;
            }
            catch (Exception ex)
            {
                // Log exception for service context here  
                throw;
            }
        }
    }
}
