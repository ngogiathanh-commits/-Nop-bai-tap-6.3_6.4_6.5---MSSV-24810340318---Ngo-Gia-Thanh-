using System.Data.SqlClient;

namespace ProjectTaskSystem.DAL
{
    public class DatabaseConnection
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLPT;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
