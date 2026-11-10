using GarageSystem.DAL;
using GarageSystem.DTO;

namespace GarageSystem.BUS
{
    public class XeBUS
    {
        private XeDAL dal = new XeDAL();

        public XeDTO GetXeByBienSo(string bienSo)
        {
            if (string.IsNullOrWhiteSpace(bienSo)) return null;
            return dal.GetXeByBienSo(bienSo.Trim());
        }

        public bool TiepNhanXeMoi(KhachHangDTO kh, XeDTO xe, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(xe.BienSo))
            {
                error = "Biển số xe không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(kh.TenKH) || string.IsNullOrWhiteSpace(kh.DienThoai))
            {
                error = "Tên chủ xe và số điện thoại không được để trống!";
                return false;
            }

            return dal.TiepNhanXeMoi(kh, xe, out error);
        }
    }
}
