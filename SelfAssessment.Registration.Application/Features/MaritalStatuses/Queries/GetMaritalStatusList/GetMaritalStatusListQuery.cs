using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.MaritalStatuses.Queries.GetMaritalStatusList
{
    public class GetMaritalStatusListQuery:IRequest<List<GetMaritalStatusListVm>>
    {
    }
}
