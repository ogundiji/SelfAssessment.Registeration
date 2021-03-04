using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.Towns.Queries.GetTownList
{
    public class GetTownListQueryHandler : IRequestHandler<GetTownListQuery, List<GetTownListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Town> townRepository;
        public GetTownListQueryHandler(IMapper mapper, IAsyncRepository<Town> townRepository)
        {
            this.mapper = mapper;
            this.townRepository = townRepository;
        }
        public async Task<List<GetTownListVm>> Handle(GetTownListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await townRepository.ListAllAsync();
            return mapper.Map<List<GetTownListVm>>(allRecord);
        }
    }
}
