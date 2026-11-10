using System.Data;
using System.Data.SqlClient;

namespace KaraokeManagement.DAL
{
    public class PhongHatDAL
    {
        public DataTable GetAllPhongHat()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM PhongHat";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
