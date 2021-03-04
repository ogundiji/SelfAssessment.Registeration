using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.MaritalStatuses.Queries.GetMaritalStatusList
{
    public class GetMaritalStatusListQueryHandler : IRequestHandler<GetMaritalStatusListQuery, List<GetMaritalStatusListVm>>
    { 

        private readonly IMapper mapper;
        private readonly IAsyncRepository<MaritalStatus> repository;
        public GetMaritalStatusListQueryHandler(IMapper mapper, IAsyncRepository<MaritalStatus> repository)
        {
           this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<List<GetMaritalStatusListVm>> Handle(GetMaritalStatusListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await repository.ListAllAsync();
            return mapper.Map<List<GetMaritalStatusListVm>>(allRecord);
        }
    }
}
