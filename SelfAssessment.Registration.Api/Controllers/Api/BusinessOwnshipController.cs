using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfAssessment.Registration.Application.Features.BusinessOwnships.Queries.GetBusinessOwnshipList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessOwnshipController : ControllerBase
    {
        private readonly IMediator mediator;
        public BusinessOwnshipController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var dtos = await mediator.Send(new GetBusinessOwnshiplistQuery());
            return Ok(dtos);
        }
    }
}
