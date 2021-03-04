using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("BusinessSubClass", Schema = "Setting")]
    public class BusinessSubClass
    {
        public int BusinessSubClassID { get; set; }
        public string BusinessSubName { get; set; }
    }
}
