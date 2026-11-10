using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProjectTaskSystem.DTO;

namespace ProjectTaskSystem.DAL
{
    public class CongViecDAL
    {
        
        public DataTable GetTaskByDuAnAndTrangThai(int maDuAn, string trangThai)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT cv.MaTask, cv.TenTask, cv.MoTa, cv.HanNop, cv.DoUuTien, cv.TrangThai, 
                                        ISNULL(STUFF((
                                            SELECT ', ' + tv.HoTen 
                                            FROM PhanCong pc 
                                            JOIN ThanhVien tv ON pc.MaThanhVien = tv.MaThanhVien 
                                            WHERE pc.MaTask = cv.MaTask 
                                            FOR XML PATH('')
                                        ), 1, 2, ''), N'Chưa giao') AS NguoiThucHien
                                 FROM CongViec cv
                                 WHERE cv.MaDuAn = @MaDuAn";

                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    query += " AND cv.TrangThai = @TrangThai";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

       
        public bool InsertTaskWithAssignment(CongViecDTO task, List<int> listMaThanhVien, out string error)
        {
            error = "";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sqlTask = @"INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) 
                                       VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai);
                                       SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdTask = new SqlCommand(sqlTask, conn, tran);
                    cmdTask.Parameters.AddWithValue("@MaDuAn", task.MaDuAn);
                    cmdTask.Parameters.AddWithValue("@TenTask", task.TenTask);
                    cmdTask.Parameters.AddWithValue("@MoTa", (object)task.MoTa ?? DBNull.Value);
                    cmdTask.Parameters.AddWithValue("@HanNop", task.HanNop);
                    cmdTask.Parameters.AddWithValue("@DoUuTien", task.DoUuTien);
                    cmdTask.Parameters.AddWithValue("@TrangThai", task.TrangThai);

                    int maTask = Convert.ToInt32(cmdTask.ExecuteScalar());

                   
                    foreach (int maTV in listMaThanhVien)
                    {
                        string sqlPC = @"INSERT INTO PhanCong (MaTask, MaThanhVien, NgayGiao) 
                                         VALUES (@MaTask, @MaThanhVien, GETDATE())";
                        SqlCommand cmdPC = new SqlCommand(sqlPC, conn, tran);
                        cmdPC.Parameters.AddWithValue("@MaTask", maTask);
                        cmdPC.Parameters.AddWithValue("@MaThanhVien", maTV);
                        cmdPC.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    error = "Lỗi SqlTransaction: " + ex.Message;
                    return false;
                }
            }
        }

       
        public bool UpdateTaskStatus(int maTask, string newStatus)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@TrangThai", newStatus));
                cmd.Parameters.Add(new SqlParameter("@MaTask", maTask));

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        
        public List<string> GetOverdueTasks()
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT cv.TenTask, da.TenDuAn, cv.HanNop, cv.TrangThai
                                 FROM CongViec cv
                                 JOIN DuAn da ON cv.MaDuAn = da.MaDuAn
                                 WHERE cv.HanNop < GETDATE() AND cv.TrangThai != N'Done'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenTask = reader["TenTask"].ToString();
                    string tenDuAn = reader["TenDuAn"].ToString();
                    DateTime hanNop = Convert.ToDateTime(reader["HanNop"]);
                    string trangThai = reader["TrangThai"].ToString();
                    list.Add($"[{tenDuAn}] {tenTask} - Hạn: {hanNop:dd/MM/yyyy HH:mm} ({trangThai})");
                }
            }
            return list;
        }

        
        public decimal GetOverallCompletionRate(int maDuAn)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT CAST(ISNULL(SUM(CASE WHEN TrangThai = N'Done' THEN 1.0 ELSE 0.0 END) * 100.0 / NULLIF(COUNT(*), 0), 0) AS DECIMAL(5,2)) 
                                 FROM CongViec WHERE MaDuAn = @MaDuAn";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }

        
        public DataTable GetMemberCompletionRate(int maDuAn)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT tv.HoTen, 
                                        COUNT(cv.MaTask) AS TongTask,
                                        SUM(CASE WHEN cv.TrangThai = N'Done' THEN 1 ELSE 0 END) AS TaskHoanThanh,
                                        CAST(ROUND(CAST(SUM(CASE WHEN cv.TrangThai = N'Done' THEN 1 ELSE 0 END) AS FLOAT) * 100 / NULLIF(COUNT(cv.MaTask), 0), 2) AS DECIMAL(5,2)) AS TyLeHoanThanh
                                 FROM ThanhVien tv
                                 JOIN PhanCong pc ON tv.MaThanhVien = pc.MaThanhVien
                                 JOIN CongViec cv ON pc.MaTask = cv.MaTask
                                 WHERE cv.MaDuAn = @MaDuAn
                                 GROUP BY tv.HoTen";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
