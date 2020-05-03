using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class SupplierMaster
    {
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Location { get; set; }
        public DateTime? SupplierAddedDate { get; set; }
        public string SupplierAddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
