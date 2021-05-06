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
    public class BlindDAL : IRepository<Blinds>, IConvertToObject<Blinds>
    {
        public bool Delete(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Blind_Delete", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "BlindID", id);
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

        public bool Delete(Blinds model)
        {
            throw new NotImplementedException();
        }

        public Blinds Get(int id)
        {
            throw new NotImplementedException();
        }

        public Blinds Get(Blinds model)
        {
            throw new NotImplementedException();
        }

        public List<Blinds> GetAll()
        {
            try
            {
                List<Blinds> lista = null;
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Blind_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lista = new List<Blinds>();
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

        public bool Insert(Blinds model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Blind_Insert", CommandType.StoredProcedure))
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

        public Blinds ToObject(SqlDataReader reader)
        {
            Blinds blind = new Blinds
            {
                BlindID = int.Parse(reader["BlindID"].ToString()),
                Name = reader["Name"].ToString(),
                Other = reader["Other"].ToString(),
                InsertBy = int.Parse(reader["InsertBy"].ToString()),
                InsertDate = Convert.ToDateTime(reader["InsertDate"].ToString()),
                LUB = int.Parse(reader["LUB"].ToString()),
                LUN = int.Parse(reader["LUN"].ToString()),
                LUD = Convert.ToDateTime(reader["LUD"].ToString())
            };

            return blind;
        }

        public bool Update(Blinds model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Blind_Update", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "BlindID", model.BlindID);
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
