using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Application.Features.ViewPaymentInfos.Queries.SearchByParam
{
    public class GetViewPaymentInfoVm
    {
        public string PayerName { get; set; }
        public string UTIN { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string MerchantCode { get; set; }
        public string LgaName { get; set; }
        public string PayerType { get; set; }
        //public string StaffNumber { get; set; }
        public string CACNumber { get; set; }
    }
}
