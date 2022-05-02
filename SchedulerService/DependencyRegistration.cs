using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchedulerServiceContract;
using SchedulerServices.V1;

namespace SchedulerServices
{
    public static class DependencyRegistration
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAttendeeService, AttendeeService>();
            services.AddScoped<IEventService, EventService>();

            DataAccess.DependencyRegistration.RegisterRepository(services, configuration);
        }
    }
}
