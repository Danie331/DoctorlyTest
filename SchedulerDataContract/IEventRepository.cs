
using SchedulerDomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchedulerDataContract
{
    public interface IEventRepository
    {
        Task AddAsync(Event @event);
        Task UpdateAsync(Event @event);
        Task CancelAsync(int id);
        Task<Event> SearchByIdAsync(int id);
        Task<IEnumerable<Event>> SearchByDescriptionAsync(string desc);
    }
}
