using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.BusinessSubClasses.Queries.GetBusinessSubClassList
{
    public class GetBusinessSubClassListQueryHandler : IRequestHandler<GetBusinessSubClassListQuery, List<GetbusinesSubClassListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<BusinessSubClass> businessRepository;
        public GetBusinessSubClassListQueryHandler(IMapper mapper, IAsyncRepository<BusinessSubClass> businessRepository)
        {
            this.mapper = mapper;
            this.businessRepository = businessRepository;
        }
        public async Task<List<GetbusinesSubClassListVm>> Handle(GetBusinessSubClassListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await businessRepository.ListAllAsync();
            return mapper.Map<List<GetbusinesSubClassListVm>>(allRecord);
        }
    }
}
