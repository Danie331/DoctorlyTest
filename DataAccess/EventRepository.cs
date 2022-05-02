
using SchedulerDataContract;
using SchedulerDomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EventRepository : IEventRepository
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
