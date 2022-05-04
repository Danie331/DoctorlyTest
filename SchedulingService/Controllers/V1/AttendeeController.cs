using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SchedulerServiceContract;
using System.Net;
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

        [HttpPost, Route("add"), SwaggerResponse(HttpStatusCode.OK, typeof(ModelDto.AttendeeDto)), SwaggerResponse(HttpStatusCode.InternalServerError, typeof(ModelDto.ApiError))]
        public async Task<IActionResult> CreateAttendee([FromBody] ModelDto.AttendeeDto attendeeDto)
        {
            var attendee = ToDomain<Domain.Attendee, ModelDto.AttendeeDto>(attendeeDto);
            var attendeeResult = await _attendeeService.AddAsync(attendee);

            return Ok(ToDto<ModelDto.AttendeeDto, Domain.Attendee>(attendeeResult));
        }
    }
}
