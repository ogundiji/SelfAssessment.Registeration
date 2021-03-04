using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Entities
{
    [Table("Lga", Schema = "Setting")]
    public class Lga
    {
        public int LgaId { get; set; }
        public string LgaName { get; set; }
        public int StateId { get; set; }
    }
}
