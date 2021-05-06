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
    public class WindowPaneDAL : IRepository<WindowPanes>, IConvertToObject<WindowPanes>
    {
        public bool Delete(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_WindowPane_Delete", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "WindowPaneID", id);
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

        public bool Delete(WindowPanes model)
        {
            throw new NotImplementedException();
        }

        public WindowPanes Get(int id)
        {
            throw new NotImplementedException();
        }

        public WindowPanes Get(WindowPanes model)
        {
            throw new NotImplementedException();
        }

        public List<WindowPanes> GetAll()
        {
            try
            {
                List<WindowPanes> lista = null;
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_WindowPane_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lista = new List<WindowPanes>();
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

        public bool Insert(WindowPanes model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_WindowPane_Insert", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "Name", model.Name);
                        DataConnection.AddParameter(command, "Other", model.Other);
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

        public WindowPanes ToObject(SqlDataReader reader)
        {
            WindowPanes wind = new WindowPanes
            {
                WindowPaneID = int.Parse(reader["WindowPaneID"].ToString()),
                Name = reader["Name"].ToString(),
                Other = reader["Other"].ToString(),
                InsertBy = int.Parse(reader["InsertBy"].ToString()),
                InsertDate = Convert.ToDateTime(reader["InsertDate"].ToString()),
                LUB = int.Parse(reader["LUB"].ToString()),
                LUN = int.Parse(reader["LUN"].ToString()),
                LUD = Convert.ToDateTime(reader["LUD"].ToString())
            };
            return wind;
        }

        public bool Update(WindowPanes model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_WindowPane_Update", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "WindowPaneID", model.WindowPaneID);
                        DataConnection.AddParameter(command, "Name", model.Name);
                        DataConnection.AddParameter(command, "Other", model.Other);
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
