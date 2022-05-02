
using SchedulerDomainModels;
using SchedulerServiceContract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchedulerServices.V1
{
    public class EventService : IEventService
    {
        public Task AddAsync(Event @event)
        {
            throw new System.NotImplementedException();
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
