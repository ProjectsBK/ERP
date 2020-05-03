using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Purchase
    {
        public string PurchaseRequestNo { get; set; }
        public string ParNo { get; set; }
        public int? RequestQty { get; set; }
        public string RequestedBy { get; set; }
        public string PoNumberToSupplier { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? PoQtyToSupplier { get; set; }
        public string PurchaseOrderStatus { get; set; }
        public string SupplierName { get; set; }
        public string PoRelesedBy { get; set; }
        public DateTime? PoRelesedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
