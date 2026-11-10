using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GarageSystem.DTO;

namespace GarageSystem.DAL
{
    public class PhieuSuaChuaDAL
    {
        
        public bool LapPhieuSuaChuaWithTransaction(PhieuSuaChuaDTO phieu, List<ChiTietSuaChuaDTO> listChiTiet, out string errorMessage)
        {
            errorMessage = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    
                    string sqlPhieu = @"INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) 
                                       VALUES (@BienSo, GETDATE(), @NoiDungSua, @TongTien, N'Đang sửa');
                                       SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdPhieu = new SqlCommand(sqlPhieu, conn, tran);
                    cmdPhieu.Parameters.AddWithValue("@BienSo", phieu.BienSo);
                    cmdPhieu.Parameters.AddWithValue("@NoiDungSua", (object)phieu.NoiDungSua ?? DBNull.Value);
                    cmdPhieu.Parameters.AddWithValue("@TongTien", phieu.TongTien);

                    int maPhieu = Convert.ToInt32(cmdPhieu.ExecuteScalar());

                   
                    foreach (var item in listChiTiet)
                    {
                        
                        string sqlCheckTon = "SELECT SoLuongTon FROM PhuTung WHERE MaPhuTung = @MaPhuTung";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheckTon, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@MaPhuTung", item.MaPhuTung);

                        object tonObj = cmdCheck.ExecuteScalar();
                        int tonHienTai = tonObj != null ? Convert.ToInt32(tonObj) : 0;

                        if (tonHienTai < item.SoLuong)
                        {
                           
                            tran.Rollback();
                            errorMessage = $"Phụ tùng '{item.TenPhuTung}' không đủ số lượng tồn trong kho! (Tồn: {tonHienTai}, Cần: {item.SoLuong})";
                            return false;
                        }

                        
                        string sqlCT = @"INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) 
                                         VALUES (@MaPhieu, @MaPhuTung, @SoLuong, @TienCong)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmdCT.Parameters.AddWithValue("@MaPhuTung", item.MaPhuTung);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@TienCong", item.TienCong);
                        cmdCT.ExecuteNonQuery();

                        
                        string sqlTruTon = "UPDATE PhuTung SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaPhuTung = @MaPhuTung";
                        SqlCommand cmdTru = new SqlCommand(sqlTruTon, conn, tran);
                        cmdTru.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdTru.Parameters.AddWithValue("@MaPhuTung", item.MaPhuTung);
                        cmdTru.ExecuteNonQuery();
                    }

                    
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    errorMessage = "Lỗi hệ thống SqlTransaction: " + ex.Message;
                    return false;
                }
            }
        }

        
        public DataTable GetPhieuChuaThanhToanByBienSo(string bienSo)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM PhieuSuaChua WHERE BienSo = @BienSo AND TrangThai != N'Đã thanh toán'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BienSo", bienSo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        
        public bool ThanhToanPhieuSuaChua(int maPhieu)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE PhieuSuaChua SET TrangThai = N'Đã thanh toán' WHERE MaPhieu = @MaPhieu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
