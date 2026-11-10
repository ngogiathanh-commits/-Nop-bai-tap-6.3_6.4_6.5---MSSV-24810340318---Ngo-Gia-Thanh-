using System.Data;
using System.Data.SqlClient;

namespace KaraokeManagement.DAL
{
    public class DichVuDAL
    {
        public DataTable GetAllDichVu()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM DichVu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
