using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("Gender", Schema = "Setting")]
    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderType { get; set; }
    }
}
