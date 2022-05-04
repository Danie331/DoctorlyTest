
using SchedulerDomainModels;
using System.Threading.Tasks;

namespace SchedulerServiceContract
{
    public interface IAttendeeService
    {
        Task<Attendee> AddAsync(Attendee attendee);
    }
}
