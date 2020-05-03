using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Stores
    {
        public string IndentNumber { get; set; }
        public string SaleOrderNo { get; set; }
        public DateTime? IndenetRaisedDate { get; set; }
        public int? IndentRaisedQty { get; set; }
        public string IndentRaisedBy { get; set; }
        public string IssuedQtyAgainstIndent { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string IssuedBy { get; set; }

        public virtual PoEntry SaleOrderNoNavigation { get; set; }
    }
}
