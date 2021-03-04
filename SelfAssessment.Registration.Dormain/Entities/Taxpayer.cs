using SelfAssessment.Registration.Dormain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("TaxPayer", Schema = "Registration")]
    public class Taxpayer:BaseModel
    {
        public string PayerUtin { get; set; }
        public string TaxPayerReferenceNumber { get; set; }
        public string CourtesyTitle { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public int? GenderId { get; set; }
        public DateTime? DateofBirth { get; set; }
        public int? MaritalStatusId { get; set; }
        public string MerchantCode { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsRegConfirmed { get; set; }
        public string ChannelCode { get; set; }
        public string CountryCode { get; set; }
        public string Jtbtin { get; set; }
        public int? BusinessTypeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmploymentAddress { get; set; }
        public int? EmploymentType { get; set; }
        public string TaxAgentReferenceNumber { get; set; }
        public string RegTypeCode { get; set; }
        public long? StaffNumber { get; set; }
    }
}
