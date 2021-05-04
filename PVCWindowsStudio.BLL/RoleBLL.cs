using PVCWindowsStudio.BO;
using PVCWindowsStudio.BO.Interfaces;
using PVCWindowsStudio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BLL
{
    public class RoleBLL : IRepository<Roles>
    {
        private readonly RoleDAL dal = new RoleDAL();
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }

        public bool Delete(Roles model)
        {
            throw new NotImplementedException();
        }

        public Roles Get(int id)
        {
            throw new NotImplementedException();
        }

        public Roles Get(Roles model)
        {
            throw new NotImplementedException();
        }

        public List<Roles> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(Roles model)
        {
            return dal.Insert(model);
        }

        public bool Update(Roles model)
        {
            return dal.Update(model);
        }
    }
}
