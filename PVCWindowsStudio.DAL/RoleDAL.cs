using PVCWindowsStudio.BO;
using PVCWindowsStudio.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PVCWindowsStudio.DAL
{
    public class RoleDAL : IRepository<Roles>, IConvertToObject<Roles>
    {
        public bool Delete(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Role_Delete", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "RoleId", id);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }

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
            try
            {
                List<Roles> lista = null;
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Role_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lista = new List<Roles>();
                            while (reader.Read())
                            {
                                lista.Add(ToObject(reader));
                            }
                        }
                    }
                }
                return lista;
            }
            catch
            {
                return null;
            }
        }

        public bool Insert(Roles model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Role_Insert", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "Name", model.Name);
                        DataConnection.AddParameter(command, "InsertBy", model.InsertBy);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }        

        public Roles ToObject(SqlDataReader reader)
        {
            Roles role = new Roles
            {
                RoleID = int.Parse(reader["RoleID"].ToString()),
                Name = reader["Name"].ToString(),
                InsertBy = int.Parse(reader["InsertBy"].ToString()),
                InsertDate = Convert.ToDateTime(reader["InsertDate"].ToString()),
                LUB = int.Parse(reader["LUB"].ToString()),                
                LUN = int.Parse(reader["LUN"].ToString()),
                LUD = Convert.ToDateTime(reader["LUD"].ToString())

            };
            return role;
        }

        public bool Update(Roles model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Role_Update", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "Name", model.Name);
                        DataConnection.AddParameter(command, "RoleId", model.RoleID);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
