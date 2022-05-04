
using SchedulerDomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchedulerServiceContract
{
    public interface IEventService
    {
        Task<Event> AddAsync(Event @event);
        Task UpdateAsync(Event @event);
        Task CancelAsync(int id);
        Task<Event> SearchByIdAsync(int id);
        Task<IEnumerable<Event>> SearchByDescriptionAsync(string desc);
    }
}
