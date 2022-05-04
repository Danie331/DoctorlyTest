
using SchedulerDataContract;
using SchedulerDomainModels;
using SchedulerServiceContract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchedulerServices.V1
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<Event> AddAsync(Event @event)
        {
            try
            {
                var result = await _eventRepository.AddAsync(@event);

                // Validation can optionally be performed here to ensure the result is a valid domain object
                return result;
            }
            catch (Exception ex)
            {
                // Log exception for service context here  
                throw;
            }
        }

        public Task CancelAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Event>> SearchByDescriptionAsync(string desc)
        {
            throw new System.NotImplementedException();
        }

        public Task<Event> SearchByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Event @event)
        {
            throw new System.NotImplementedException();
        }
    }
}
