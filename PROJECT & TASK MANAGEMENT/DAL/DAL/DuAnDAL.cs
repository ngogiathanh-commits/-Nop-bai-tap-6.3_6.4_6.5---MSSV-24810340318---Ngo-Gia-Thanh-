using System.Data;
using System.Data.SqlClient;
using ProjectTaskSystem.DTO;

namespace ProjectTaskSystem.DAL
{
    public class DuAnDAL
    {
        public DataTable GetAllDuAn()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM DuAn";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool InsertDuAn(DuAnDTO duAn)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) 
                                 VALUES (@TenDuAn, @NgayBatDau, @NgayKetThuc, @TrangThai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDuAn", duAn.TenDuAn);
                cmd.Parameters.AddWithValue("@NgayBatDau", duAn.NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", duAn.NgayKetThuc);
                cmd.Parameters.AddWithValue("@TrangThai", duAn.TrangThai);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
