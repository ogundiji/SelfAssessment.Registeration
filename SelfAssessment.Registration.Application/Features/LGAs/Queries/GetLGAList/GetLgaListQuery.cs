using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.LGAs.Queries.GetLGAList
{
    public class GetLgaListQuery:IRequest<List<GetLgaListVm>>
    {
    }
}
