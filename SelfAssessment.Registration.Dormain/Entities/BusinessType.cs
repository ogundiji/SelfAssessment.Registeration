using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("BusinessType", Schema = "Setting")]
    public class BusinessType
    {
        public int BusinessTypeId { get; set; }
        public string BusinessTypeName { get; set; }
    }
}
