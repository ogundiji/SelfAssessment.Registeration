using SelfAssessment.Registration.Dormain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Contracts.Persistence
{
    public interface IGenderRepository:IAsyncRepository<Gender>
    {
    }
}
