using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BO
{
    public class ProductItems : AuditColumns
    {
        public int ProductItemsID { get; set; }
        public int ProductID { get; set; }
        public int ProfileID { get; set; }
        public int MaterialID { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int Quantity { get; set; }
        public string Formula { get; set; }
        public decimal Total { get; set; }
        public virtual Materials Materials { get; set; }

    }
}
