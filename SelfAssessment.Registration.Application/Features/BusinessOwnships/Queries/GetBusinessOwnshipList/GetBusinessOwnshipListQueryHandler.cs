using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.BusinessOwnships.Queries.GetBusinessOwnshipList
{
    public class GetBusinessOwnshipListQueryHandler : IRequestHandler<GetBusinessOwnshiplistQuery, List<BusinessOwnshipListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<BusinessOwnship> businessOwnshipRepository;

        public GetBusinessOwnshipListQueryHandler(IMapper mapper, IAsyncRepository<BusinessOwnship> businessOwnshipRepository)
        {
            this.mapper = mapper;
        }
        public async Task<List<BusinessOwnshipListVm>> Handle(GetBusinessOwnshiplistQuery request, CancellationToken cancellationToken)
        {
            var allRecords = await businessOwnshipRepository.ListAllAsync();
            return mapper.Map<List<BusinessOwnshipListVm>>(allRecords);
        }
    }
}
