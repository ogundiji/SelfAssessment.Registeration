using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.States.Queries.GetStateList
{
    public class GetStateListQuery:IRequest<List<GetStateListVm>>
    {
    }
}
