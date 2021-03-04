using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("vwPayerInfo", Schema = "dbo")]
    public class ViewPayerInfo
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
        [NotMapped]
        public bool IsFilterdByPhone { get; set; }
        [NotMapped]
        public string SearchParam { get; set; }
    }
}
