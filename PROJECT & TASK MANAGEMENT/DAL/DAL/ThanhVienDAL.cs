using System.Data;
using System.Data.SqlClient;

namespace ProjectTaskSystem.DAL
{
    public class ThanhVienDAL
    {
        public DataTable GetAllThanhVien()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM ThanhVien";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
