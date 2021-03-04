using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.Towns.Queries.GetTownList
{
    public class GetTownListQuery:IRequest<List<GetTownListVm>>
    {
    }
}
