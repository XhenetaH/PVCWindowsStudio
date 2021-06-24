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
    public class UserDAL : IRepository<Users>, IConvertToObject<Users>
    {
        public bool Delete(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_User_Delete", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "UserID", id);
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
            try
            {
                List<Users> lista = null;
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_User_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lista = new List<Users>();
                            while (reader.Read())
                            {
                                var user = ToObject(reader);
                                user.Role = new Roles
                                {
                                    Name = reader["RoleName"].ToString()
                                };

                                lista.Add(user);
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

        public bool Insert(Users model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_User_Insert", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "RoleID", model.RoleID);
                        DataConnection.AddParameter(command, "UserName", model.UserName);
                        DataConnection.AddParameter(command, "Password", model.Password);
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

        public Users Login(string username, string password)
        {
            try
            {
                using (var conn = DataConnection.GetConnection())
                {
                    using (var cmd = DataConnection.Command(conn, "dbo.usp_Authenticate", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(cmd, "username", username);
                        DataConnection.AddParameter(cmd, "password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            Users result = null;
                            if (reader.Read())
                            {
                                result = ToObject(reader);
                            }

                            return result;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }


        }

        public Users ToObject(SqlDataReader reader)
        {
            Users user = new Users
            {
                UserID = int.Parse(reader["UserID"].ToString()),
                UserName = reader["UserName"].ToString(),
                Password = reader["Password"].ToString(),
                RoleID = int.Parse(reader["RoleID"].ToString()),
                Role = new Roles()
                {
                    Name = reader["RoleName"].ToString()
                }
            };

            return user;
        }

        public bool Update(Users model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_User_Update", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "UserID", model.UserID);
                        DataConnection.AddParameter(command, "UserName", model.UserName);
                        DataConnection.AddParameter(command, "Password", model.Password);
                        DataConnection.AddParameter(command, "RoleID", model.RoleID);
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
