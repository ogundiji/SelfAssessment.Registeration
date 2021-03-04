using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam
{
    public class GetPayerByParamQueryHandler : IRequestHandler<GetPayerByParamQuery, List<GetViewPaymentInfoVm>>
    {
        private readonly IMapper mapper;
        private IPayerRepository repository;
        public GetPayerByParamQueryHandler(IMapper mapper, IPayerRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        public async  Task<List<GetViewPaymentInfoVm>> Handle(GetPayerByParamQuery request, CancellationToken cancellationToken)
        {
            var allRecord =  await repository.GetAllRecord(request.param);
            return mapper.Map<List<GetViewPaymentInfoVm>>(allRecord);
        }
    }
}
