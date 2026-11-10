using System.Data;
using KaraokeManagement.DAL;

namespace KaraokeManagement.BUS
{
    public class PhongHatBUS
    {
        private PhongHatDAL dal = new PhongHatDAL();
        public DataTable GetAllPhongHat() => dal.GetAllPhongHat();
    }
}
