using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfAssessment.Registration.Application.Features.Genders.Queries.GetGenderList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IMediator mediator;
        public GenderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var dtos = await mediator.Send(new GenderListQuery());
            return Ok(dtos);
        }
    }
}
