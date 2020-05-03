using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Marketing
    {
        public string EnquiryNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerDetails { get; set; }
        public string EnquiryDetailsEnteredBy { get; set; }
        public DateTime? EquiryDetailsEnteredDate { get; set; }
        public string QuoteNo { get; set; }
        public string QuoteCreatedBy { get; set; }
        public DateTime? QuoteCreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
