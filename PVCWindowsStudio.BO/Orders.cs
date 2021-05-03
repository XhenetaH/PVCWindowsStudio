using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BO
{
    public class Orders : AuditColumns
    {
        public int OrderID { get; set; }
        public Clients ClientID { get; set; }
        public DateTime Date { get; set; }
        public string Others { get; set; }
    }
}
