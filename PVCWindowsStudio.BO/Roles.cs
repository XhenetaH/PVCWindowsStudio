using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BO
{
    public class Roles : AuditColumns
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public virtual List<Users> User { get; set; }

    }
}
