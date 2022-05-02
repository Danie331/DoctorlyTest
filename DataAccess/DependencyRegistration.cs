
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchedulerDataContract;

namespace DataAccess
{
    public static class DependencyRegistration
    {
        public static void RegisterRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAttendeeRepository, AttendeeRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddDbContext<EventSchedulerContext>(options => options.UseSqlServer(configuration.GetConnectionString("EventScheduler")));
        }
    }
}
