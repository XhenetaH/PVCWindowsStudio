using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BO
{
    public class Invoices : AuditColumns
    {
        public int InvoiceID { get; set; }
        public Orders Order { get; set; }
        public string Comment { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
