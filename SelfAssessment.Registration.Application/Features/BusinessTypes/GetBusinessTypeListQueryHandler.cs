using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.BusinessTypes
{
    public class GetBusinessTypeListQueryHandler : IRequestHandler<GetBusinessTypeListQuery, List<GetBusinessTypeListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<BusinessType> businessRepository;
        public GetBusinessTypeListQueryHandler(IMapper mapper, IAsyncRepository<BusinessType> businessRepository)
        {
            this.businessRepository = businessRepository;
            this.mapper = mapper;
        }
        public async Task<List<GetBusinessTypeListVm>> Handle(GetBusinessTypeListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await businessRepository.ListAllAsync();
            return mapper.Map<List<GetBusinessTypeListVm>>(allRecord);
        }
    }
}
