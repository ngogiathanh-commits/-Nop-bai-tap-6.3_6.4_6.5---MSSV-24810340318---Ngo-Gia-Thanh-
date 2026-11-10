using System.Data;
using KaraokeManagement.DAL;
using KaraokeManagement.DTO;

namespace KaraokeManagement.BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public HoaDonDTO GetHoaDonActiveByMaPhong(int maPhong) => dal.GetHoaDonActiveByMaPhong(maPhong);
        public bool MoPhong(int maPhong) => dal.MoPhong(maPhong);
        public DataTable GetChiTietDichVuByHoaDon(int maHD) => dal.GetChiTietDichVuByHoaDon(maHD);
        public bool ThemDichVuVaoHoaDon(int maHD, int maDV, int soLuong, decimal donGia) => dal.ThemDichVuVaoHoaDon(maHD, maDV, soLuong, donGia);
        public bool ThanhToanWithTransaction(int maHD, int maPhong, decimal tongTienPhong, decimal tongTienDV, out string error)
        {
            return dal.ThanhToanWithTransaction(maHD, maPhong, tongTienPhong, tongTienDV, out error);
        }
    }
}
