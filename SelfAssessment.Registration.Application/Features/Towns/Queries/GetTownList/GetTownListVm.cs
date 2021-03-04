using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.Towns.Queries.GetTownList
{
    public class GetTownListVm
    {
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int LgaId { get; set; }
    }
}
