using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SchedulingService.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IMapper _mapper;
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected U ToDto<U, T>(T source) => _mapper.Map<T, U>(source);

        protected IEnumerable<U> ToDtoList<U, T>(IEnumerable<T> source) => _mapper.Map<IEnumerable<T>, IEnumerable<U>>(source);

        protected U ToDomain<U, T>(T source) => _mapper.Map<T, U>(source);

        protected IEnumerable<U> ToDomainList<U, T>(IEnumerable<T> source) => _mapper.Map<IEnumerable<T>, IEnumerable<U>>(source);
    }
}
