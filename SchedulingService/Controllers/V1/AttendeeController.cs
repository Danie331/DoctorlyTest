using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchedulerServiceContract;
using System.Threading.Tasks;
using Domain = SchedulerDomainModels;

namespace SchedulingService.Controllers.V1
{
    [Route("api/v1/attendee")]
    [ApiController]
    public class AttendeeController : BaseController
    {
        private readonly IAttendeeService _attendeeService;

        public AttendeeController(IAttendeeService attendeeService, IMapper mapper) : base(mapper)
        {
            _attendeeService = attendeeService;
        }

        [HttpPost, Route("add")]
        public async Task<IActionResult> CreateAttendee([FromBody] ModelDto.AttendeeDto attendeeDto)
        {
            var attendee = ToDomain<Domain.Attendee, ModelDto.AttendeeDto>(attendeeDto);
            await _attendeeService.AddAsync(attendee);

            return Ok();
        }
    }
}
