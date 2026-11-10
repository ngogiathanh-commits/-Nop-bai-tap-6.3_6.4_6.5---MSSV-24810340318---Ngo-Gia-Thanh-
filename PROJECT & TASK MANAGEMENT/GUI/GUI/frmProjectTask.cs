using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ProjectTaskSystem.BUS;
using ProjectTaskSystem.DAL;
using ProjectTaskSystem.DTO;

namespace ProjectTaskSystem.GUI
{
    public partial class frmProjectTask : Form
    {
        private DuAnBUS duAnBUS = new DuAnBUS();
        private CongViecBUS taskBUS = new CongViecBUS();
        private ThanhVienDAL tvDAL = new ThanhVienDAL();

        private int selectedMaTask = -1;

        private bool TryGetSelectedDuAnId(ComboBox comboBox, out int maDuAn)
        {
            maDuAn = 0;
            object selectedValue = comboBox.SelectedValue;

            if (selectedValue is DataRowView rowView)
            {
                selectedValue = rowView["MaDuAn"];
            }

            return selectedValue != null
                && selectedValue != DBNull.Value
                && int.TryParse(selectedValue.ToString(), out maDuAn);
        }

        public frmProjectTask()
        {
            InitializeComponent();
        }

        private void frmProjectTask_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCboDuAn();
                LoadListThanhVien();
                cboStatusFilter.SelectedIndex = 0;
                cboDoUuTien.SelectedIndex = 1;
                cboTrangThaiTask.SelectedIndex = 0;

                KiemTraTaskTreHan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể tải dữ liệu từ cơ sở dữ liệu. Kiểm tra SQL Server và database QLPT.\n\nChi tiết: {ex.Message}",
                    "Lỗi kết nối cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void LoadCboDuAn()
        {
            DataTable dt = duAnBUS.GetAllDuAn();
            cboDuAnFilter.DataSource = dt;
            cboDuAnFilter.DisplayMember = "TenDuAn";
            cboDuAnFilter.ValueMember = "MaDuAn";

            cboDuAnTaoTask.DataSource = dt.Copy();
            cboDuAnTaoTask.DisplayMember = "TenDuAn";
            cboDuAnTaoTask.ValueMember = "MaDuAn";
        }

        private void LoadListThanhVien()
        {
            DataTable dt = tvDAL.GetAllThanhVien();
            chkListThanhVien.DataSource = dt;
            chkListThanhVien.DisplayMember = "HoTen";
            chkListThanhVien.ValueMember = "MaThanhVien";
        }

        
        private void btnLocTask_Click(object sender, EventArgs e)
        {
            LoadGridTask();
            CapNhatThongKeTienDo();
        }

        private void LoadGridTask()
        {
            if (!TryGetSelectedDuAnId(cboDuAnFilter, out int maDuAn)) return;
            string trangThai = cboStatusFilter.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(trangThai)) return;

            dgvTask.DataSource = taskBUS.GetTaskByDuAnAndTrangThai(maDuAn, trangThai);
        }

        
        private void btnTaoTask_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedDuAnId(cboDuAnTaoTask, out int maDuAn)) return;
            string tenTask = txtTenTask.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            DateTime hanNop = dtpHanNop.Value;
            string doUuTien = cboDoUuTien.SelectedItem.ToString();
            string trangThai = cboTrangThaiTask.SelectedItem.ToString();

            List<int> listMaTV = new List<int>();
            foreach (var item in chkListThanhVien.CheckedItems)
            {
                DataRowView drv = item as DataRowView;
                listMaTV.Add(Convert.ToInt32(drv["MaThanhVien"]));
            }

            CongViecDTO task = new CongViecDTO
            {
                MaDuAn = maDuAn,
                TenTask = tenTask,
                MoTa = moTa,
                HanNop = hanNop,
                DoUuTien = doUuTien,
                TrangThai = trangThai
            };

            if (taskBUS.ThemTask(task, listMaTV, out string error))
            {
                MessageBox.Show("Thêm mới và phân công công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridTask();
                CapNhatThongKeTienDo();
            }
            else
            {
                MessageBox.Show(error, "Lỗi Validation / SqlTransaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            if (selectedMaTask == -1)
            {
                MessageBox.Show("Vui lòng chọn 1 công việc từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cboCapNhatTrangThai.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus)) return;

            if (taskBUS.CapNhatTrangThai(selectedMaTask, newStatus))
            {
                MessageBox.Show($"Đã chuyển trạng thái Task #{selectedMaTask} sang '{newStatus}'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridTask();
                CapNhatThongKeTienDo();
                KiemTraTaskTreHan();
            }
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTask.Rows[e.RowIndex];
                selectedMaTask = Convert.ToInt32(row.Cells["MaTask"].Value);
                cboCapNhatTrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            }
        }

       
        private void KiemTraTaskTreHan()
        {
            lstTaskTreHan.Items.Clear();
            List<string> overdueList = taskBUS.GetOverdueTasks();
            foreach (var item in overdueList)
            {
                lstTaskTreHan.Items.Add(item);
            }

            if (overdueList.Count > 0)
            {
                lblCanhBaoTreHan.Text = $"CẢNH BÁO: Phát hiện {overdueList.Count} công việc quá hạn chưa hoàn thành!";
            }
            else
            {
                lblCanhBaoTreHan.Text = "Không có công việc nào bị trễ hạn.";
            }
        }

        
        private void CapNhatThongKeTienDo()
        {
            if (!TryGetSelectedDuAnId(cboDuAnFilter, out int maDuAn)) return;

            decimal percent = taskBUS.GetOverallCompletionRate(maDuAn);
            lblTienDoTong.Text = $"Tỷ lệ hoàn thành dự án: {percent}%";

            dgvThongKeThanhVien.DataSource = taskBUS.GetMemberCompletionRate(maDuAn);
        }

        private void cboDuAnFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridTask();
            CapNhatThongKeTienDo();
        }
    }
}
