using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class GaugeMaster
    {
        public string GaugeCode { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public DateTime? CalibrationDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? Quantity { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
