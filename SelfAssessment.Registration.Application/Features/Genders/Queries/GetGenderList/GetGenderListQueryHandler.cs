using AutoMapper;
using MediatR;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Features.Genders.Queries.GetGenderList
{
    public class GetGenderListQueryHandler : IRequestHandler<GenderListQuery, List<GenderListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Gender> genderRepository;
        public GetGenderListQueryHandler(IMapper mapper, IAsyncRepository<Gender> genderRepository)
        {
            this.mapper = mapper;
            this.genderRepository = genderRepository;
        }
        public async Task<List<GenderListVm>> Handle(GenderListQuery request, CancellationToken cancellationToken)
        {
            var allRecord = await  genderRepository.ListAllAsync();
            return mapper.Map<List<GenderListVm>>(allRecord);
        }
    }
}
