using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using KaraokeManagement.BUS;
using KaraokeManagement.DTO;

namespace KaraokeManagement.GUI
{
    public partial class frmKaraoke : Form
    {
        private PhongHatBUS phongBUS = new PhongHatBUS();
        private DichVuBUS dichVuBUS = new DichVuBUS();
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();

        private int selectedMaPhong = -1;
        private string selectedTenPhong = "";
        private decimal selectedGiaTheoGio = 0;
        private string selectedTrangThaiPhong = "";

        private HoaDonDTO currentHoaDon = null;
        private DataTable dtChiTietDV = null;

        public frmKaraoke()
        {
            InitializeComponent();
        }

        private void frmKaraoke_Load(object sender, EventArgs e)
        {
            LoadSoDoPhong();
            LoadDichVuCombo();
        }

        
        private void LoadSoDoPhong()
        {
            flpPhongHat.Controls.Clear();
            DataTable dtPhong = phongBUS.GetAllPhongHat();

            foreach (DataRow row in dtPhong.Rows)
            {
                int maPhong = Convert.ToInt32(row["MaPhong"]);
                string tenPhong = row["TenPhong"].ToString();
                string loaiPhong = row["LoaiPhong"].ToString();
                decimal giaTheoGio = Convert.ToDecimal(row["GiaTheoGio"]);
                string trangThai = row["TrangThai"].ToString();

                Button btn = new Button
                {
                    Width = 110,
                    Height = 90,
                    Text = $"{tenPhong}\n({loaiPhong})\n[{trangThai}]",
                    Tag = row,
                    Font = new Font("Arial", 9, FontStyle.Bold)
                };

                
                if (trangThai == "Trống")
                {
                    btn.BackColor = Color.LightGreen;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.LightCoral;
                    btn.ForeColor = Color.White;
                }

                btn.Click += BtnPhong_Click;
                flpPhongHat.Controls.Add(btn);
            }
        }

        
        private void BtnPhong_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataRow row = btn.Tag as DataRow;

            selectedMaPhong = Convert.ToInt32(row["MaPhong"]);
            selectedTenPhong = row["TenPhong"].ToString();
            selectedGiaTheoGio = Convert.ToDecimal(row["GiaTheoGio"]);
            selectedTrangThaiPhong = row["TrangThai"].ToString();

            lblTenPhongDangChon.Text = selectedTenPhong;
            lblGiaPhong.Text = $"{selectedGiaTheoGio:N0} VNĐ/Giờ";

            if (selectedTrangThaiPhong == "Đang hát")
            {
                btnMoPhong.Enabled = false;
                btnThanhToan.Enabled = true;
                btnThemDV.Enabled = true;

                currentHoaDon = hoaDonBUS.GetHoaDonActiveByMaPhong(selectedMaPhong);
                if (currentHoaDon != null)
                {
                    lblGioVao.Text = currentHoaDon.GioVao.ToString("dd/MM/yyyy HH:mm:ss");
                    LoadDichVuHoaDon(currentHoaDon.MaHD);
                }
            }
            else
            {
                btnMoPhong.Enabled = true;
                btnThanhToan.Enabled = false;
                btnThemDV.Enabled = false;

                lblGioVao.Text = "--:--";
                currentHoaDon = null;
                dgvDichVu.DataSource = null;
                TinhTongTienThanhToan();
            }
        }

        
        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            if (selectedMaPhong == -1 || selectedTrangThaiPhong != "Trống") return;

            if (hoaDonBUS.MoPhong(selectedMaPhong))
            {
                MessageBox.Show($"Mở {selectedTenPhong} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSoDoPhong();
                ResetFormState();
            }
        }

        
        private void LoadDichVuCombo()
        {
            cboDichVu.DataSource = dichVuBUS.GetAllDichVu();
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
        }

        private void LoadDichVuHoaDon(int maHD)
        {
            dtChiTietDV = hoaDonBUS.GetChiTietDichVuByHoaDon(maHD);
            dgvDichVu.DataSource = dtChiTietDV;
            TinhTongTienThanhToan();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (currentHoaDon == null || cboDichVu.SelectedValue == null) return;

            int maDV = Convert.ToInt32(cboDichVu.SelectedValue);
            DataRowView drv = cboDichVu.SelectedItem as DataRowView;
            decimal donGia = Convert.ToDecimal(drv["DonGia"]);
            int soLuong = (int)nudSoLuongDV.Value;

            if (hoaDonBUS.ThemDichVuVaoHoaDon(currentHoaDon.MaHD, maDV, soLuong, donGia))
            {
                LoadDichVuHoaDon(currentHoaDon.MaHD);
            }
        }

        
        private void TinhTongTienThanhToan()
        {
            decimal tongTienDV = 0;
            if (dtChiTietDV != null)
            {
                foreach (DataRow row in dtChiTietDV.Rows)
                {
                    tongTienDV += Convert.ToDecimal(row["ThanhTien"]);
                }
            }
            lblTienDichVu.Text = $"{tongTienDV:N0} VNĐ";

            decimal tongTienPhong = 0;
            if (currentHoaDon != null)
            {
                TimeSpan duration = DateTime.Now - currentHoaDon.GioVao;
                double tongSoGio = Math.Max(0.1, duration.TotalHours); 
                tongTienPhong = (decimal)tongSoGio * selectedGiaTheoGio;
                lblTienPhong.Text = $"{tongTienPhong:N0} VNĐ ({duration.Hours}h {duration.Minutes}m)";
            }
            else
            {
                lblTienPhong.Text = "0 VNĐ";
            }

            decimal tongCong = tongTienPhong + tongTienDV;
            lblTongTien.Text = $"{tongCong:N0} VNĐ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (currentHoaDon == null) return;

            TimeSpan duration = DateTime.Now - currentHoaDon.GioVao;
            double tongSoGio = Math.Max(0.1, duration.TotalHours);
            decimal tongTienPhong = (decimal)tongSoGio * selectedGiaTheoGio;

            decimal tongTienDV = 0;
            if (dtChiTietDV != null)
            {
                foreach (DataRow row in dtChiTietDV.Rows)
                {
                    tongTienDV += Convert.ToDecimal(row["ThanhTien"]);
                }
            }

            decimal tongCong = tongTienPhong + tongTienDV;

            string msg = $"XÁC NHẬN THANH TOÁN {selectedTenPhong}\n" +
                         $"Thời gian hát: {duration.Hours} giờ {duration.Minutes} phút ({tongTienPhong:N0} VNĐ)\n" +
                         $"Tiền dịch vụ: {tongTienDV:N0} VNĐ\n" +
                         $"----------------------------------------\n" +
                         $"TỔNG THANH TOÁN: {tongCong:N0} VNĐ";

            if (MessageBox.Show(msg, "Xác nhận Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (hoaDonBUS.ThanhToanWithTransaction(currentHoaDon.MaHD, selectedMaPhong, tongTienPhong, tongTienDV, out string error))
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSoDoPhong();
                    LoadDichVuCombo();
                    ResetFormState();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi SqlTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetFormState()
        {
            selectedMaPhong = -1;
            selectedTrangThaiPhong = "";
            currentHoaDon = null;
            dtChiTietDV = null;
            lblTenPhongDangChon.Text = "Chưa chọn phòng";
            lblGiaPhong.Text = "0 VNĐ/Giờ";
            lblGioVao.Text = "--:--";
            lblTienPhong.Text = "0 VNĐ";
            lblTienDichVu.Text = "0 VNĐ";
            lblTongTien.Text = "0 VNĐ";
            dgvDichVu.DataSource = null;
            btnMoPhong.Enabled = false;
            btnThanhToan.Enabled = false;
            btnThemDV.Enabled = false;
        }

        private void btnCapNhatGiaoDien_Click(object sender, EventArgs e)
        {
            if (currentHoaDon != null)
            {
                TinhTongTienThanhToan();
            }
        }
    }
}