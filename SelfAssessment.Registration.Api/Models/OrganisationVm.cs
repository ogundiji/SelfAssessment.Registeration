using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Models
{
    public class OrganisationVm
    {
        public string OrganisationName { get; set; }
        public string OrganisationAbbrv { get; set; }
        public string Branchname { get; set; }
        public string CacRegisterationDate { get; set; }
        public string RegisterationNo { get; set; }
        public string OfficeLine { get; set; }
        public string MobileLine { get; set; }
        public string OfficeLoc { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalAddress { get; set; }
        public string City { get; set; }
        public string TaxOffice { get; set; }
        public string BusinessSector { get; set; }
        public string BusinessSubsector { get; set; }
        public string BusinessSubclass { get; set; }
        public string Email { get; set; }
        public string Director1 { get; set; }
        public string Director2 { get; set; }
        public string PayerType { get; set; }
        public string ContactName { get; set; }
        public string Designation { get; set; }
        public string ContactPhoneNo { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNo2 { get; set; }
    }
}
