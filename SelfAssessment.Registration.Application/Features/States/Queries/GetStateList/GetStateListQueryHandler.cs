using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.States.Queries.GetStateList
{
    public class GetStateListQueryHandler : IRequestHandler<GetStateListQuery, List<GetStateListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<State> stateRepository;
        public GetStateListQueryHandler(IMapper mapper, IAsyncRepository<State> stateRepository)
        {
            this.stateRepository = stateRepository;
            this.mapper = mapper;
        }
        public async Task<List<GetStateListVm>> Handle(GetStateListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await stateRepository.ListAllAsync();
            return mapper.Map<List<GetStateListVm>>(allRecord);
        }
    }
}
