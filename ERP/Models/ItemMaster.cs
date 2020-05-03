using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class ItemMaster
    {
        public ItemMaster()
        {
            PoEntry = new HashSet<PoEntry>();
            PriceMaster = new HashSet<PriceMaster>();
        }

        public string ProductNo { get; set; }
        public string Description { get; set; }
        public string ModelNo { get; set; }
        public string Condition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual ICollection<PoEntry> PoEntry { get; set; }
        public virtual ICollection<PriceMaster> PriceMaster { get; set; }
    }
}
