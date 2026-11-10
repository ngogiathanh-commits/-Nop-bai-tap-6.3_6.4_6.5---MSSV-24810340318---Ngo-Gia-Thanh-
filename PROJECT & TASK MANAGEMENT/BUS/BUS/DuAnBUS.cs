using System.Data;
using ProjectTaskSystem.DAL;
using ProjectTaskSystem.DTO;

namespace ProjectTaskSystem.BUS
{
    public class DuAnBUS
    {
        private DuAnDAL dal = new DuAnDAL();

        public DataTable GetAllDuAn() => dal.GetAllDuAn();

        public bool ThemDuAn(DuAnDTO duAn, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(duAn.TenDuAn))
            {
                error = "Tên dự án không được để trống!";
                return false;
            }
            if (duAn.NgayKetThuc < duAn.NgayBatDau)
            {
                error = "Ngày kết thúc phải lớn hơn ngày bắt đầu!";
                return false;
            }
            return dal.InsertDuAn(duAn);
        }
    }
}
