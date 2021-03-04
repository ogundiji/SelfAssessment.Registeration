using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("Town", Schema = "Setting")]
    public class Town
    {
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int LgaId { get; set; }
    }
}
