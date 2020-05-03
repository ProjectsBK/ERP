using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class ProcessMaster
    {
        public string ProductNo { get; set; }
        public int? OperationCode { get; set; }
        public string OperationName { get; set; }

        public virtual ItemMaster ProductNoNavigation { get; set; }
    }
}
