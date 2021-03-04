using AutoMapper;
using SelfAssessment.Registration.Application.Features.BusinessOwnships.Queries.GetBusinessOwnshipList;
using SelfAssessment.Registration.Application.Features.BusinessSubClasses.Queries.GetBusinessSubClassList;
using SelfAssessment.Registration.Application.Features.BusinessTypes;
using SelfAssessment.Registration.Application.Features.Genders.Queries.GetGenderList;
using SelfAssessment.Registration.Application.Features.LGAs.Queries.GetLGAList;
using SelfAssessment.Registration.Application.Features.LGAs.Queries.GetStateLga;
using SelfAssessment.Registration.Application.Features.MaritalStatuses.Queries.GetMaritalStatusList;
using SelfAssessment.Registration.Application.Features.States.Queries.GetStateList;
using SelfAssessment.Registration.Application.Features.Towns.Queries.GetTownList;
using SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam;
using SelfAssessment.Registration.Dormain.Entities;

namespace SelfAssessment.Registration.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BusinessOwnship,BusinessOwnshipListVm>();
            CreateMap<Town, GetTownListVm>();
            CreateMap<State, GetStateListVm>();
            CreateMap<MaritalStatus, GetMaritalStatusListVm>();
            CreateMap<Lga, GetLgaListVm>();
            CreateMap<Lga, StateLgaVm>();
            CreateMap<Gender, GenderListVm>();
            CreateMap<BusinessType, GetBusinessTypeListVm>();
            CreateMap<BusinessSubClass, GetbusinesSubClassListVm>();
            CreateMap<BusinessOwnship, BusinessOwnshipListVm>();
            CreateMap<ViewPayerInfo, GetViewPaymentInfoVm>();
        }
    }
}
