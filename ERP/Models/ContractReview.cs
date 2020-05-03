using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class ContractReview
    {
        public string ContractReviewCode { get; set; }
        public string SaleOrderNo { get; set; }
        public DateTime? PackingDate { get; set; }
        public DateTime? PromiseDate { get; set; }
        public DateTime? RevisedDeliveryDate { get; set; }

        public virtual PoEntry SaleOrderNoNavigation { get; set; }
    }
}
