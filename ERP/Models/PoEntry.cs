using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class PoEntry
    {
        public PoEntry()
        {
            ContractReview = new HashSet<ContractReview>();
            Invoice = new HashSet<Invoice>();
            Stores = new HashSet<Stores>();
        }

        public string PoNo { get; set; }
        public string PosNo { get; set; }
        public DateTime? PoDate { get; set; }
        public DateTime? PoReceivedDate { get; set; }
        public DateTime? OrderEntryDate { get; set; }
        public string CastingDrawingNo { get; set; }
        public string MachiningDrawingNumber { get; set; }
        public string CustomerCode { get; set; }
        public string ProductNo { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CustomerRequiredDate { get; set; }
        public string SaleOrderNo { get; set; }
        public string GradeId { get; set; }
        public string PriceMasterCode { get; set; }
        public string ConditionOfSupply { get; set; }
        public string Category { get; set; }
        public string ModeOfShipment { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual CustomerMaster CustomerCodeNavigation { get; set; }
        public virtual GradeMaster Grade { get; set; }
        public virtual PriceMaster PriceMasterCodeNavigation { get; set; }
        public virtual ItemMaster ProductNoNavigation { get; set; }
        public virtual ICollection<ContractReview> ContractReview { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Stores> Stores { get; set; }
    }
}
