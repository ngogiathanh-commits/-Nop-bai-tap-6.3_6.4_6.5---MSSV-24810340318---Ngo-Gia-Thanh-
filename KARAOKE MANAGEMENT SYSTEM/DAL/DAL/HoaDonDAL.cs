using System;
using System.Data;
using System.Data.SqlClient;
using KaraokeManagement.DTO;

namespace KaraokeManagement.DAL
{
    public class HoaDonDAL
    {
        
        public HoaDonDTO GetHoaDonActiveByMaPhong(int maPhong)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM HoaDon WHERE MaPhong = @MaPhong AND TrangThai = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new HoaDonDTO
                    {
                        MaHD = (int)reader["MaHD"],
                        MaPhong = (int)reader["MaPhong"],
                        GioVao = Convert.ToDateTime(reader["GioVao"]),
                        TongTienPhong = Convert.ToDecimal(reader["TongTienPhong"]),
                        TongTienDichVu = Convert.ToDecimal(reader["TongTienDichVu"]),
                        TrangThai = (bool)reader["TrangThai"]
                    };
                }
                return null;
            }
        }

        
        public bool MoPhong(int maPhong)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                   
                    string insertHD = "INSERT INTO HoaDon (MaPhong, GioVao, TrangThai) VALUES (@MaPhong, GETDATE(), 0)";
                    SqlCommand cmdHD = new SqlCommand(insertHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdHD.ExecuteNonQuery();

                    
                    string updatePhong = "UPDATE PhongHat SET TrangThai = N'Đang hát' WHERE MaPhong = @MaPhong";
                    SqlCommand cmdPhong = new SqlCommand(updatePhong, conn, tran);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdPhong.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        
        public DataTable GetChiTietDichVuByHoaDon(int maHD)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT c.MaDV, d.TenDV, c.SoLuong, c.DonGia, (c.SoLuong * c.DonGia) AS ThanhTien 
                                 FROM ChiTietDichVu c 
                                 JOIN DichVu d ON c.MaDV = d.MaDV 
                                 WHERE c.MaHD = @MaHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        
        public bool ThemDichVuVaoHoaDon(int maHD, int maDV, int soLuong, decimal donGia)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    IF EXISTS (SELECT 1 FROM ChiTietDichVu WHERE MaHD = @MaHD AND MaDV = @MaDV)
                        UPDATE ChiTietDichVu SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaDV = @MaDV
                    ELSE
                        INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia) VALUES (@MaHD, @MaDV, @SoLuong, @DonGia)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@MaDV", maDV);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGia", donGia);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        
        public bool ThanhToanWithTransaction(int maHD, int maPhong, decimal tongTienPhong, decimal tongTienDV, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    
                    string sqlGetCT = "SELECT MaDV, SoLuong FROM ChiTietDichVu WHERE MaHD = @MaHD";
                    SqlCommand cmdCT = new SqlCommand(sqlGetCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD);

                    SqlDataAdapter da = new SqlDataAdapter(cmdCT);
                    DataTable dtCT = new DataTable();
                    da.Fill(dtCT);

                    foreach (DataRow row in dtCT.Rows)
                    {
                        int maDV = Convert.ToInt32(row["MaDV"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);

                        
                        string sqlCheck = "SELECT TonKho, TenDV FROM DichVu WHERE MaDV = @MaDV";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaDV", maDV);
                        SqlDataReader reader = cmdCheck.ExecuteReader();

                        if (reader.Read())
                        {
                            int tonKho = Convert.ToInt32(reader["TonKho"]);
                            string tenDV = reader["TenDV"].ToString();
                            reader.Close();

                            if (tonKho < soLuong)
                            {
                                tran.Rollback();
                                error = $"Mặt hàng '{tenDV}' không đủ tồn kho để chốt thanh toán! (Còn: {tonKho}, Dùng: {soLuong})";
                                return false;
                            }
                        }
                        else
                        {
                            reader.Close();
                        }

                        
                        string sqlTru = "UPDATE DichVu SET TonKho = TonKho - @SoLuong WHERE MaDV = @MaDV";
                        SqlCommand cmdTru = new SqlCommand(sqlTru, conn, tran);
                        cmdTru.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdTru.Parameters.AddWithValue("@MaDV", maDV);
                        cmdTru.ExecuteNonQuery();
                    }

                   
                    string sqlHD = @"UPDATE HoaDon 
                                     SET GioRa = GETDATE(), TongTienPhong = @TongTienPhong, 
                                         TongTienDichVu = @TongTienDichVu, TrangThai = 1 
                                     WHERE MaHD = @MaHD";
                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@TongTienPhong", tongTienPhong);
                    cmdHD.Parameters.AddWithValue("@TongTienDichVu", tongTienDV);
                    cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                    cmdHD.ExecuteNonQuery();

                    
                    string sqlPhong = "UPDATE PhongHat SET TrangThai = N'Trống' WHERE MaPhong = @MaPhong";
                    SqlCommand cmdPhong = new SqlCommand(sqlPhong, conn, tran);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdPhong.ExecuteNonQuery();

                   
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi khi xử lý SqlTransaction thanh toán: " + ex.Message;
                    return false;
                }
            }
        }
    }
}
