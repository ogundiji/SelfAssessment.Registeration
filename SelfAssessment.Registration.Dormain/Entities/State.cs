using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("State", Schema = "Setting")]
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
