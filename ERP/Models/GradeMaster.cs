using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class GradeMaster
    {
        public GradeMaster()
        {
            PoEntry = new HashSet<PoEntry>();
        }

        public string GradeId { get; set; }
        public string GradeName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual ICollection<PoEntry> PoEntry { get; set; }
    }
}
