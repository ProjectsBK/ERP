using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class CustomerMaster
    {
        public CustomerMaster()
        {
            PoEntry = new HashSet<PoEntry>();
        }

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Location { get; set; }
        public DateTime? CustomerAddedDate { get; set; }
        public string CustomerAddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual ICollection<PoEntry> PoEntry { get; set; }
    }
}
