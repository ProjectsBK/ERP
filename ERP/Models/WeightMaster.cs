using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class WeightMaster
    {
        public string WeightMasterCode { get; set; }
        public string ProductNo { get; set; }
        public int? CastingWeight { get; set; }
        public int? WeightAfterFullMachining { get; set; }

        public virtual ItemMaster ProductNoNavigation { get; set; }
    }
}
