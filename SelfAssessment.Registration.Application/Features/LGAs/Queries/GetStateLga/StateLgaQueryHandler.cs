using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.LGAs.Queries.GetStateLga
{
    public class StateLgaQueryHandler : IRequestHandler<StateLgaQuery, List<StateLgaVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Lga> repository;

        public StateLgaQueryHandler(IMapper mapper, IAsyncRepository<Lga> repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        public async Task<List<StateLgaVm>> Handle(StateLgaQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await repository.ListAllAsync();
            var filteredRecord = allRecord.ToList().Where(x => x.StateId == request.StateId);

            return mapper.Map<List<StateLgaVm>>(filteredRecord);
        }
    }
}
