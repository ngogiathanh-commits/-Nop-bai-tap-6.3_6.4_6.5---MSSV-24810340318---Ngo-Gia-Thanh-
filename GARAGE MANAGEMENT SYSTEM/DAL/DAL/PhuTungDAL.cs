using System.Data;
using System.Data.SqlClient;
using GarageSystem.DTO;

namespace GarageSystem.DAL
{
    public class PhuTungDAL
    {
        public DataTable GetAllPhuTung()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM PhuTung";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool InsertPhuTung(PhuTungDTO pt)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES (@TenPhuTung, @DonGia, @SoLuongTon)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenPhuTung", pt.TenPhuTung);
                cmd.Parameters.AddWithValue("@DonGia", pt.DonGia);
                cmd.Parameters.AddWithValue("@SoLuongTon", pt.SoLuongTon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdatePhuTung(PhuTungDTO pt)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE PhuTung SET TenPhuTung = @TenPhuTung, DonGia = @DonGia, SoLuongTon = @SoLuongTon WHERE MaPhuTung = @MaPhuTung";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhuTung", pt.MaPhuTung);
                cmd.Parameters.AddWithValue("@TenPhuTung", pt.TenPhuTung);
                cmd.Parameters.AddWithValue("@DonGia", pt.DonGia);
                cmd.Parameters.AddWithValue("@SoLuongTon", pt.SoLuongTon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
