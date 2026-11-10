using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GarageSystem.BUS;
using GarageSystem.DTO;

namespace GarageSystem.GUI
{
    public partial class frmGarage : Form
    {
        private XeBUS xeBUS = new XeBUS();
        private PhuTungBUS phuTungBUS = new PhuTungBUS();
        private PhieuSuaChuaBUS phieuBUS = new PhieuSuaChuaBUS();

        private List<ChiTietSuaChuaDTO> listChiTiet = new List<ChiTietSuaChuaDTO>();
        private XeDTO currentXe = null;

        public frmGarage()
        {
            InitializeComponent();
        }

        private void frmGarage_Load(object sender, EventArgs e)
        {
            LoadCboPhuTung();
            LoadDataPhuTungTab();
        }

        private void LoadCboPhuTung()
        {
            DataTable dt = phuTungBUS.GetAllPhuTung();
            cboPhuTung.DataSource = dt;
            cboPhuTung.DisplayMember = "TenPhuTung";
            cboPhuTung.ValueMember = "MaPhuTung";
        }

        private void LoadDataPhuTungTab()
        {
            dgvPhuTungKho.DataSource = phuTungBUS.GetAllPhuTung();
        }

        
        private void btnTimXe_Click(object sender, EventArgs e)
        {
            string bienSo = txtTimBienSo.Text.Trim();
            currentXe = xeBUS.GetXeByBienSo(bienSo);

            if (currentXe != null)
            {
                txtBienSo.Text = currentXe.BienSo;
                txtTenKH.Text = currentXe.TenKH;
                txtDienThoai.Text = currentXe.DienThoai;
                txtHieuXe.Text = currentXe.HieuXe;
                nudNamSX.Value = currentXe.NamSanXuat;

                btnTiepNhanMoi.Enabled = false;
                MessageBox.Show($"Tìm thấy thông tin xe [{currentXe.BienSo}] thuộc chủ xe '{currentXe.TenKH}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuChuaThanhToan(currentXe.BienSo);
            }
            else
            {
                MessageBox.Show("Xe mới chưa có trong hệ thống! Vui lòng nhập thông tin Chủ xe để tiếp nhận mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBienSo.Text = bienSo;
                txtTenKH.Clear();
                txtDienThoai.Clear();
                txtDiaChi.Clear();
                txtHieuXe.Clear();
                btnTiepNhanMoi.Enabled = true;
                dgvPhieuChuaTT.DataSource = null;
            }
        }

        
        private void btnTiepNhanMoi_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO
            {
                TenKH = txtTenKH.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            XeDTO xe = new XeDTO
            {
                BienSo = txtBienSo.Text.Trim(),
                HieuXe = txtHieuXe.Text.Trim(),
                NamSanXuat = (int)nudNamSX.Value
            };

            if (xeBUS.TiepNhanXeMoi(kh, xe, out string error))
            {
                MessageBox.Show("Tiếp nhận xe mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentXe = xeBUS.GetXeByBienSo(xe.BienSo);
                btnTiepNhanMoi.Enabled = false;
            }
            else
            {
                MessageBox.Show(error, "Lỗi Tiếp Nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (cboPhuTung.SelectedValue == null) return;

            int maPT = Convert.ToInt32(cboPhuTung.SelectedValue);
            DataRowView drv = cboPhuTung.SelectedItem as DataRowView;
            string tenPT = drv["TenPhuTung"].ToString();
            decimal donGia = Convert.ToDecimal(drv["DonGia"]);

            int soLuong = (int)nudSoLuongPT.Value;
            decimal tienCong = nudTienCong.Value;

            var existing = listChiTiet.FirstOrDefault(x => x.MaPhuTung == maPT);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
                existing.TienCong += tienCong;
            }
            else
            {
                listChiTiet.Add(new ChiTietSuaChuaDTO
                {
                    MaPhuTung = maPT,
                    TenPhuTung = tenPT,
                    DonGia = donGia,
                    SoLuong = soLuong,
                    TienCong = tienCong
                });
            }

            CapNhatGridChiTiet();
        }

        private void CapNhatGridChiTiet()
        {
            dgvChiTietSua.DataSource = null;
            dgvChiTietSua.DataSource = listChiTiet;

            decimal tongTien = listChiTiet.Sum(x => x.ThanhTien);
            lblTongTienPhieu.Text = $"{tongTien:N0} VNĐ";
        }

       
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (currentXe == null)
            {
                MessageBox.Show("Vui lòng tra cứu hoặc tiếp nhận xe trước khi lập phiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTien = listChiTiet.Sum(x => x.ThanhTien);
            PhieuSuaChuaDTO phieu = new PhieuSuaChuaDTO
            {
                BienSo = currentXe.BienSo,
                NoiDungSua = txtNoiDungSua.Text.Trim(),
                TongTien = tongTien
            };

            if (phieuBUS.LapPhieuSuaChuaWithTransaction(phieu, listChiTiet, out string error))
            {
                MessageBox.Show("Lập phiếu sửa chữa thành công và đã trừ phụ tùng trong kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listChiTiet.Clear();
                CapNhatGridChiTiet();
                LoadCboPhuTung();
                LoadDataPhuTungTab();
                LoadPhieuChuaThanhToan(currentXe.BienSo);
            }
            else
            {
                MessageBox.Show(error, "Lỗi SqlTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuChuaTT.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu sửa chữa cần thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maPhieu = Convert.ToInt32(dgvPhieuChuaTT.CurrentRow.Cells["MaPhieu"].Value);
            decimal tongTien = Convert.ToDecimal(dgvPhieuChuaTT.CurrentRow.Cells["TongTien"].Value);

            if (MessageBox.Show($"Xác nhận thanh toán Hóa đơn Phiếu #{maPhieu}?\nTổng chi phí: {tongTien:N0} VNĐ", "Xác nhận Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (phieuBUS.ThanhToanPhieuSuaChua(maPhieu))
                {
                    MessageBox.Show("Thanh toán thành công! Trạng thái chuyển sang 'Đã thanh toán'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuChuaThanhToan(currentXe.BienSo);
                }
            }
        }

        private void LoadPhieuChuaThanhToan(string bienSo)
        {
            dgvPhieuChuaTT.DataSource = phieuBUS.GetPhieuChuaThanhToanByBienSo(bienSo);
        }

        
        private void btnThemPT_Click(object sender, EventArgs e)
        {
            PhuTungDTO pt = new PhuTungDTO
            {
                TenPhuTung = txtTenPT.Text.Trim(),
                DonGia = nudDonGiaPT.Value,
                SoLuongTon = (int)nudSoLuongTonPT.Value
            };

            if (phuTungBUS.ThemPhuTung(pt, out string error))
            {
                MessageBox.Show("Thêm phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataPhuTungTab();
                LoadCboPhuTung();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
