using Microsoft.EntityFrameworkCore;
using SelfAssessment.Registration.Application.Contracts.Persistence;
using SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam;
using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Persistence.Repositories
{
    public class PayerRepository : BaseRepository<ViewPayerInfo>, IPayerRepository
    {
        private readonly SelfAssessmentDbContext context;
        public PayerRepository(SelfAssessmentDbContext context):base(context)
        {
            this.context = context;
        }
        public async Task<List<ViewPayerInfo>> GetAllRecord(string param)
        {
            string searchResult = param.ToLower();
            return await context.ViewPayerInfo
                .Where(x => x.PayerName.ToLower().Contains(searchResult) || x.UTIN.ToLower().Contains(searchResult) || x.Email.ToLower().Contains(searchResult) || x.TelephoneNumber.ToLower().Contains(searchResult))
                .ToListAsync();
        }
    }
}
