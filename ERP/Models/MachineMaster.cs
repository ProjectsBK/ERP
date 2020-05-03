using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class MachineMaster
    {
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public DateTime? DateOfPurchased { get; set; }
        public int? MachineHourRate { get; set; }
        public string MachineMake { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
