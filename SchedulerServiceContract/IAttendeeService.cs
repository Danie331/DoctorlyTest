
using SchedulerDomainModels;
using System.Threading.Tasks;

namespace SchedulerServiceContract
{
    public interface IAttendeeService
    {
        Task AddAsync(Attendee attendee);
    }
}
