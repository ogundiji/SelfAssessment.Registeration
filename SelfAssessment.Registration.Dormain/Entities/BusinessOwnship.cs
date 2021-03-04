using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("BusinessOwnship", Schema = "Setting")]
    public class BusinessOwnship
    {
        public int BusinessOwnshipID { get; set; }
        public string BusinessOwnshipName { get; set; }
    }
}
