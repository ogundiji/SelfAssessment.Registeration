using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.BusinessSubClasses.Queries.GetBusinessSubClassList
{
    public class GetBusinessSubClassListQuery:IRequest<List<GetbusinesSubClassListVm>>
    {
    }
}
