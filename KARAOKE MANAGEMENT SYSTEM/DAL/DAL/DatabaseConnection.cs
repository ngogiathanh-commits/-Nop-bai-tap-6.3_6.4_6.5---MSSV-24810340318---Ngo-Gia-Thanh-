using System.Data.SqlClient;

namespace KaraokeManagement.DAL
{
    public class DatabaseConnection
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLK;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
