
using AutoMapper;
using DataAccess.Entities;
using SchedulerDataContract;
using SchedulerDomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain = SchedulerDomainModels;
using Data = DataAccess.Entities;
using System;

namespace DataAccess
{
    public class EventRepository : IEventRepository
    {
        private readonly IMapper _mapper;
        private readonly EventSchedulerContext _context;
        public EventRepository(EventSchedulerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Domain.Event> AddAsync(Domain.Event @event)
        {
            try
            {
                var insertEvent = _mapper.Map<Data.Event>(@event);
                var insertEventResult = await _context.Event.AddAsync(insertEvent);
                var result = await _context.SaveChangesAsync();

                return _mapper.Map<Data.Event, Domain.Event>(insertEventResult.Entity);
            }
            catch (Exception ex)
            {
                // Log exception for the repository layer
                throw;
            }
        }

        public Task CancelAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Domain.Event>> SearchByDescriptionAsync(string desc)
        {
            throw new System.NotImplementedException();
        }

        public Task<Domain.Event> SearchByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Domain.Event @event)
        {
            throw new System.NotImplementedException();
        }
    }
}
