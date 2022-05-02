
using SchedulerDomainModels;
using System.Threading.Tasks;

namespace SchedulerDataContract
{
    public interface IAttendeeRepository
    {
        Task AddAsync(Attendee attendee);
    }
}
