using System.Data.SqlClient;


namespace PVCWindowsStudio.BO.Interfaces
{
    public interface IConvertToObject<T>
    {
        T ToObject(SqlDataReader reader);
    }
}
