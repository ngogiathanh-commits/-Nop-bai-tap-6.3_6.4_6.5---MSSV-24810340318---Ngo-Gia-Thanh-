using System;
using System.Data.SqlClient;
using GarageSystem.DTO;

namespace GarageSystem.DAL
{
    public class XeDAL
    {
        
        public XeDTO GetXeByBienSo(string bienSo)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT x.BienSo, x.MaKH, k.TenKH, k.DienThoai, x.HieuXe, x.NamSanXuat 
                                 FROM Xe x 
                                 JOIN KhachHang k ON x.MaKH = k.MaKH 
                                 WHERE x.BienSo = @BienSo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@BienSo", bienSo));

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new XeDTO
                    {
                        BienSo = reader["BienSo"].ToString(),
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        TenKH = reader["TenKH"].ToString(),
                        DienThoai = reader["DienThoai"].ToString(),
                        HieuXe = reader["HieuXe"].ToString(),
                        NamSanXuat = Convert.ToInt32(reader["NamSanXuat"])
                    };
                }
                return null;
            }
        }

        
        public bool TiepNhanXeMoi(KhachHangDTO kh, XeDTO xe, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                   
                    string sqlKH = @"INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) 
                                     VALUES (@TenKH, @DienThoai, @DiaChi);
                                     SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdKH = new SqlCommand(sqlKH, conn, tran);
                    cmdKH.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmdKH.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                    cmdKH.Parameters.AddWithValue("@DiaChi", (object)kh.DiaChi ?? DBNull.Value);

                    int maKH = Convert.ToInt32(cmdKH.ExecuteScalar());

                   
                    string sqlXe = @"INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) 
                                     VALUES (@BienSo, @MaKH, @HieuXe, @NamSanXuat)";
                    SqlCommand cmdXe = new SqlCommand(sqlXe, conn, tran);
                    cmdXe.Parameters.AddWithValue("@BienSo", xe.BienSo);
                    cmdXe.Parameters.AddWithValue("@MaKH", maKH);
                    cmdXe.Parameters.AddWithValue("@HieuXe", xe.HieuXe);
                    cmdXe.Parameters.AddWithValue("@NamSanXuat", xe.NamSanXuat);
                    cmdXe.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi khi tiếp nhận xe mới: " + ex.Message;
                    return false;
                }
            }
        }
    }
}
