using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Invoice
    {
        public int InNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string SaleOrderNo { get; set; }
        public int? InvoiceQty { get; set; }

        public virtual PoEntry SaleOrderNoNavigation { get; set; }
    }
}
