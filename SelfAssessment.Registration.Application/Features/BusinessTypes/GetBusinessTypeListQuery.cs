using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.BusinessTypes
{
    public class GetBusinessTypeListQuery:IRequest<List<GetBusinessTypeListVm>>
    {
    }
}
