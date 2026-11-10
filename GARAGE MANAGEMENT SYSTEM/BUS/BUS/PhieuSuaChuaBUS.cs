using GarageSystem.DAL;
using GarageSystem.DTO;
using System.Collections.Generic;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GarageSystem.BUS
{
    public class PhieuSuaChuaBUS
    {
        private PhieuSuaChuaDAL dal = new PhieuSuaChuaDAL();

        public bool LapPhieuSuaChuaWithTransaction(PhieuSuaChuaDTO phieu, List<ChiTietSuaChuaDTO> listChiTiet, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(phieu.BienSo))
            {
                errorMessage = "Vui lòng chọn biển số xe sửa chữa!";
                return false;
            }
            if (listChiTiet == null || listChiTiet.Count == 0)
            {
                errorMessage = "Vui lòng chọn ít nhất 1 phụ tùng / dịch vụ sửa chữa!";
                return false;
            }

            return dal.LapPhieuSuaChuaWithTransaction(phieu, listChiTiet, out errorMessage);
        }

        public DataTable GetPhieuChuaThanhToanByBienSo(string bienSo) => dal.GetPhieuChuaThanhToanByBienSo(bienSo);

        public bool ThanhToanPhieuSuaChua(int maPhieu) => dal.ThanhToanPhieuSuaChua(maPhieu);
    }
}
