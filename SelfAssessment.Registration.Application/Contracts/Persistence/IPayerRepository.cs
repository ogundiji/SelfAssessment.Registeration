using SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Contracts.Persistence
{
    public interface IPayerRepository:IAsyncRepository<ViewPayerInfo>
    {
        Task<List<ViewPayerInfo>> GetAllRecord(string param);
    }
}
