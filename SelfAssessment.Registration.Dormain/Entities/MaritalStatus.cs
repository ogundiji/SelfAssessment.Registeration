using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("MaritalStatus", Schema = "Setting")]
    public class MaritalStatus
    {
        public int MaritalStatusId { get; set; }
        public string MaritalStatusType { get; set; }
    }
}
