using System;
using System.Collections.Generic;
using System.Text;

namespace SelfAssessment.Registration.Dormain.Common
{
    public class BaseModel
    {
        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public DateTime DateModified { get; set; }

        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
    }
}
