using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam
{
    public class GetPayerByParamQuery:IRequest<List<GetViewPaymentInfoVm>>
    {
        public string param { get; set; }
    }
}
