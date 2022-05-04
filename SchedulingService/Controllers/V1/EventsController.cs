using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SchedulerServiceContract;
using System.Net;
using System.Threading.Tasks;
using Domain = SchedulerDomainModels;

namespace SchedulingService.Controllers.V1
{
    [Route("api/v1/events"), ApiController]
    public class EventsController : BaseController
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService, IMapper mapper) : base(mapper)
        {
            _eventService = eventService;
        }

        [HttpPost, Route("add"), SwaggerResponse(HttpStatusCode.OK, typeof(ModelDto.EventDto)), SwaggerResponse(HttpStatusCode.InternalServerError, typeof(ModelDto.ApiError))]
        public async Task<IActionResult> CreateEvent([FromBody] ModelDto.EventDto eventDto)
        {
            var @event = ToDomain<Domain.Event, ModelDto.EventDto>(eventDto);
            var result = await _eventService.AddAsync(@event);

            return Ok(ToDto<ModelDto.EventDto, Domain.Event>(result));
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> UpdateEvent([FromBody] ModelDto.EventDto eventDto)
        {
            var @event = ToDomain<Domain.Event, ModelDto.EventDto>(eventDto);
            await _eventService.UpdateAsync(@event);

            return Ok();
        }

        [HttpPost, Route("cancel/{id}")]
        public async Task<IActionResult> CancelEvent(int id)
        {
            await _eventService.CancelAsync(id);

            return Ok();
        }

        [HttpGet, Route("id/{id}")]
        public async Task<IActionResult> SearchById(int id)
        {
            var @event = await _eventService.SearchByIdAsync(id);

            return Ok(ToDto<ModelDto.EventDto, Domain.Event>(@event));
        }

        [HttpGet, Route("description/{desc}")]
        public async Task<IActionResult> SearchByDescription(string desc)
        {
            var events = await _eventService.SearchByDescriptionAsync(desc);

            return Ok(ToDtoList<ModelDto.EventDto, Domain.Event>(events));
        }
    }
}
