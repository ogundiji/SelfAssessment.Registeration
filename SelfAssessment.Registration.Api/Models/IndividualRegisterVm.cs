using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Models
{
    public class IndividualRegisterVm
    {
        public string Courtesy { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othername { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Occupation { get; set; }
        public int GenderId { get; set; }
        public int MaritalStatusId { get; set; }
        public string DateofBirth { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public int StateId { get; set; }
        public int LGAId { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNo { get; set; }
        public string PayerType { get; set; }
    }
}
