using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SelfAssessment.Registration.Application.Features.LGAs.Queries.GetLGAList;
using SelfAssessment.Registration.Application.Features.LGAs.Queries.GetStateLga;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LgaController : ControllerBase
    {
        private readonly IMediator mediator;
        public LgaController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        //api/Lga
        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var dtos = await mediator.Send(new GetLgaListQuery());
            return Ok(dtos);
        }

        //api/Lga/id
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id)
        {
            var dtos = await mediator.Send(new StateLgaQuery() { StateId =id});
            return Ok(dtos);
        }

        
    }
}
