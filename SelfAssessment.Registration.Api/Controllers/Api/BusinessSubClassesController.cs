using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfAssessment.Registration.Application.Features.BusinessSubClasses.Queries.GetBusinessSubClassList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessSubClassesController : ControllerBase
    {
        private readonly IMediator mediator;
        public BusinessSubClassesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var dtos = await mediator.Send(new GetBusinessSubClassListQuery());
            return Ok(dtos);
        }
    }
}
