using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SelfAssessment.Registration.Application.Features.LGAs.Queries.GetStateLga;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers
{
    public class LocalGovtController : Controller
    {
        private readonly IMediator mediator;
        public LocalGovtController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [AllowAnonymous]
        public async Task<JsonResult> getLgabyStatesId(int Id)
        {
            List<StateLgaVm> list = new List<StateLgaVm>();

            var lgaUnderAState = await mediator.Send(new StateLgaQuery() { StateId = Id });
            list = lgaUnderAState.ToList();
            list.Insert(0, new StateLgaVm { LgaId = 0, LgaName = "Please Select " });
            return Json(new SelectList(list, "LgaName", "LgaName"));


        }
    }
}
