﻿using PVCWindowsStudio.BO;
using PVCWindowsStudio.BO.Interfaces;
using PVCWindowsStudio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.BLL
{
    public class OrderBLL : IRepository<Orders>
    {
        private OrderDAL dal = new OrderDAL();
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        public bool DeleteAll(int id)
        {
            return dal.DeleteAll(id);
        }
        public bool Delete(Orders model)
        {
            throw new NotImplementedException();
        }

        public Orders Get(int id)
        {
            throw new NotImplementedException();
        }

        public Orders Get(Orders model)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {
            return dal.GetAll();
        }

        public int GetID()
        {
            return dal.GetID();
        }
        public bool Insert(Orders model)
        {
            return dal.Insert(model);
        }

        public bool Update(Orders model)
        {
            return dal.Update(model);
        }
    }
}