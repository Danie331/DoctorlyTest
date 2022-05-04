
using SchedulerDomainModels;
using System.Threading.Tasks;

namespace SchedulerDataContract
{
    public interface IAttendeeRepository
    {
        Task<Attendee> AddAsync(Attendee attendee);
    }
}
