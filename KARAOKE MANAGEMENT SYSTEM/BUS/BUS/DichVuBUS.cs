using System.Data;
using KaraokeManagement.DAL;

namespace KaraokeManagement.BUS
{
    public class DichVuBUS
    {
        private DichVuDAL dal = new DichVuDAL();
        public DataTable GetAllDichVu() => dal.GetAllDichVu();
    }
}
