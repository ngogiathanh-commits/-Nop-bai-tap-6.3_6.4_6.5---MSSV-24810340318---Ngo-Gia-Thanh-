using System.Collections.Generic;
using System.Data;
using ProjectTaskSystem.DAL;
using ProjectTaskSystem.DTO;

namespace ProjectTaskSystem.BUS
{
    public class CongViecBUS
    {
        private CongViecDAL dal = new CongViecDAL();

        public DataTable GetTaskByDuAnAndTrangThai(int maDuAn, string trangThai) => dal.GetTaskByDuAnAndTrangThai(maDuAn, trangThai);

        public bool ThemTask(CongViecDTO task, List<int> listMaThanhVien, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(task.TenTask))
            {
                error = "Tên công việc không được để trống!";
                return false;
            }
            return dal.InsertTaskWithAssignment(task, listMaThanhVien, out error);
        }

        public bool CapNhatTrangThai(int maTask, string newStatus) => dal.UpdateTaskStatus(maTask, newStatus);

        public List<string> GetOverdueTasks() => dal.GetOverdueTasks();

        public decimal GetOverallCompletionRate(int maDuAn) => dal.GetOverallCompletionRate(maDuAn);

        public DataTable GetMemberCompletionRate(int maDuAn) => dal.GetMemberCompletionRate(maDuAn);
    }
}