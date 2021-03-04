using SelfAssessment.Registration.Dormain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("TaxAgent", Schema = "Registration")]
    public class TaxAgent:BaseModel
    {
        public string TaxAgentReferenceNumber { get; set; }
        public string OrganizationName { get; set; }
        public string TaxAgentTin { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? BusinessTypeId { get; set; }
        public string MerchantCode { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsRegConfirmed { get; set; }
        public string LandLine { get; set; }
        public string MobileLine { get; set; }
        public string Email { get; set; }
        public string ChannelCode { get; set; }
        public int? BusinessOwnshipId { get; set; }
        public string BranchName { get; set; }
        public string RegTypeCode { get; set; }
        public string Abbrev { get; set; }
        public string Director1 { get; set; }
        public string Director2 { get; set; }
        public int? StaffNumber { get; set; }
        public bool? IsAttendentto { get; set; }
        public bool? IsPramary { get; set; }
        public string FinalUtin { get; set; }

    }
}
