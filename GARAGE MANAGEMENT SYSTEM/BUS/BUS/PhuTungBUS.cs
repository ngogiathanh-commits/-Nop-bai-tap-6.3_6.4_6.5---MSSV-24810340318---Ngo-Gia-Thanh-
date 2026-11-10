using System.Data;
using GarageSystem.DAL;
using GarageSystem.DTO;

namespace GarageSystem.BUS
{
    public class PhuTungBUS
    {
        private PhuTungDAL dal = new PhuTungDAL();

        public DataTable GetAllPhuTung() => dal.GetAllPhuTung();

        public bool ThemPhuTung(PhuTungDTO pt, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(pt.TenPhuTung))
            {
                error = "Tên phụ tùng không được để trống!";
                return false;
            }
            if (pt.DonGia < 0 || pt.SoLuongTon < 0)
            {
                error = "Đơn giá và số lượng tồn không được âm!";
                return false;
            }

            return dal.InsertPhuTung(pt);
        }

        public bool SuaPhuTung(PhuTungDTO pt, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(pt.TenPhuTung))
            {
                error = "Tên phụ tùng không được để trống!";
                return false;
            }
            return dal.UpdatePhuTung(pt);
        }
    }
}
