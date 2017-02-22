using System.Data.SqlClient;

namespace AbstractFactory
{
    public sealed class SqlDatabase : Database
    {
        private readonly string _connectionSting;

        public SqlDatabase(string connectionStr)
        {
            _connectionSting = connectionStr;
            Connection = new SqlConnection(connectionStr);
            Command = new SqlCommand("", (SqlConnection)Connection);

        }


    }
}