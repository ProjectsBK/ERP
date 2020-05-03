using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class PriceMaster
    {
        public PriceMaster()
        {
            PoEntry = new HashSet<PoEntry>();
        }

        public string PriceMasterCode { get; set; }
        public string ProductNo { get; set; }
        public long? UnitPrice { get; set; }
        public long? ConversitionRate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CurrencyType { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual ItemMaster ProductNoNavigation { get; set; }
        public virtual ICollection<PoEntry> PoEntry { get; set; }
    }
}
