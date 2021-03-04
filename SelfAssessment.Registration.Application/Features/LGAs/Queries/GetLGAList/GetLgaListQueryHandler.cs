using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.LGAs.Queries.GetLGAList
{
    public class GetLgaListQueryHandler : IRequestHandler<GetLgaListQuery, List<GetLgaListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Lga> lgaRepository;
        public GetLgaListQueryHandler(IMapper mapper, IAsyncRepository<Lga> lgaRepository)
        {
            this.mapper = mapper;
            this.lgaRepository = lgaRepository;
        }
        public async Task<List<GetLgaListVm>> Handle(GetLgaListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await lgaRepository.ListAllAsync();
            return mapper.Map<List<GetLgaListVm>>(allRecord);
        }
    }
}
