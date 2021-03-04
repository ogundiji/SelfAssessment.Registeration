using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.LGAs.Queries.GetLGAList
{
    public class GetLgaListVm
    {
        public int LgaId { get; set; }
        public string LgaName { get; set; }
        public int StateId { get; set; }
    }
}
