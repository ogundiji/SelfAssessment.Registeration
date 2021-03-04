using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.Genders.Queries.GetGenderList
{
    public class GenderListQuery :IRequest<List<GenderListVm>>
    {

    }
}
