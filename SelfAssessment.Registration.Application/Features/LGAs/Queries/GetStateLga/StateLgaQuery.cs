using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.LGAs.Queries.GetStateLga
{
    public class StateLgaQuery:IRequest<List<StateLgaVm>>
    {
        public int StateId { get; set; }
    }
}
