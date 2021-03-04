using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewPayerController : ControllerBase
    {
        private readonly IMediator mediator;

        public ViewPayerController(IMediator mediator)
        {
            this.mediator = mediator;
           
        }

        //api/ViewPayer/value
        [HttpGet("{value}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string value)
        {
            var paramRequest = new GetPayerByParamQuery() { param = value };
            return Ok(await mediator.Send(paramRequest));
        }

       


    }
}
