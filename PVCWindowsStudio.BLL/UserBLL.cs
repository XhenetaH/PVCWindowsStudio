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
    public class UsersBLL : IRepository<Users>
    {
        private static UserDAL dal = new UserDAL();

        public static Users Login(string username, string password)
        {
            return dal.Login(username, password);
        }

        public bool Delete(int id)
        {
            return dal.Delete(id);
        }

        public bool Delete(Users model)
        {
            throw new NotImplementedException();
        }

        public Users Get(int id)
        {
            throw new NotImplementedException();
        }

        public Users Get(Users model)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(Users model)
        {
            return dal.Insert(model);
        }

        public bool Update(Users model)
        {
            return dal.Update(model);
        }
    }

}
