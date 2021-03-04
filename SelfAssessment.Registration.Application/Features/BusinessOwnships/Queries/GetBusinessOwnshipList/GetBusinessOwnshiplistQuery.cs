using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.BusinessOwnships.Queries.GetBusinessOwnshipList
{
    public class GetBusinessOwnshiplistQuery:IRequest<List<BusinessOwnshipListVm>>
    {
    }
}
