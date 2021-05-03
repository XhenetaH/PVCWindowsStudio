using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BO
{
    public class Users : AuditColumns
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual Roles Role { get; set; }
    }
}
