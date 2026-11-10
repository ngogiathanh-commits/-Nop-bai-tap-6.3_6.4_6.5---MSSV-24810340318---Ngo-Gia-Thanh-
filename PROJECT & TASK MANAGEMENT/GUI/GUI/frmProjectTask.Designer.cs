namespace ProjectTaskSystem.GUI
{
    partial class frmProjectTask
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKanban = new System.Windows.Forms.TabPage();
            this.cboCapNhatTrangThai = new System.Windows.Forms.ComboBox();
            this.btnDoiTrangThai = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.btnLocTask = new System.Windows.Forms.Button();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.cboDuAnFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.lblDuAnFilter = new System.Windows.Forms.Label();
            this.tabTaoTask = new System.Windows.Forms.TabPage();
            this.btnTaoTask = new System.Windows.Forms.Button();
            this.chkListThanhVien = new System.Windows.Forms.CheckedListBox();
            this.lblPhanCong = new System.Windows.Forms.Label();
            this.cboTrangThaiTask = new System.Windows.Forms.ComboBox();
            this.cboDoUuTien = new System.Windows.Forms.ComboBox();
            this.dtpHanNop = new System.Windows.Forms.DateTimePicker();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenTask = new System.Windows.Forms.TextBox();
            this.cboDuAnTaoTask = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDoUuTien = new System.Windows.Forms.Label();
            this.lblHanNop = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenTask = new System.Windows.Forms.Label();
            this.lblDuAnTao = new System.Windows.Forms.Label();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.dgvThongKeThanhVien = new System.Windows.Forms.DataGridView();
            this.lblTienDoTong = new System.Windows.Forms.Label();
            this.lstTaskTreHan = new System.Windows.Forms.ListBox();
            this.lblCanhBaoTreHan = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabKanban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.tabTaoTask.SuspendLayout();
            this.tabBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabKanban);
            this.tabMain.Controls.Add(this.tabTaoTask);
            this.tabMain.Controls.Add(this.tabBaoCao);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(914, 561);
            this.tabMain.TabIndex = 0;
            // 
            // tabKanban
            // 
            this.tabKanban.Controls.Add(this.cboCapNhatTrangThai);
            this.tabKanban.Controls.Add(this.btnDoiTrangThai);
            this.tabKanban.Controls.Add(this.dgvTask);
            this.tabKanban.Controls.Add(this.btnLocTask);
            this.tabKanban.Controls.Add(this.cboStatusFilter);
            this.tabKanban.Controls.Add(this.cboDuAnFilter);
            this.tabKanban.Controls.Add(this.lblStatusFilter);
            this.tabKanban.Controls.Add(this.lblDuAnFilter);
            this.tabKanban.Location = new System.Drawing.Point(4, 22);
            this.tabKanban.Name = "tabKanban";
            this.tabKanban.Padding = new System.Windows.Forms.Padding(3);
            this.tabKanban.Size = new System.Drawing.Size(906, 535);
            this.tabKanban.TabIndex = 0;
            this.tabKanban.Text = "Danh Sách & Tiến Độ Task";
            this.tabKanban.UseVisualStyleBackColor = true;
            // 
            // cboCapNhatTrangThai
            // 
            this.cboCapNhatTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapNhatTrangThai.FormattingEnabled = true;
            this.cboCapNhatTrangThai.Items.AddRange(new object[] {
            "To Do",
            "In Progress",
            "Review",
            "Done"});
            this.cboCapNhatTrangThai.Location = new System.Drawing.Point(620, 15);
            this.cboCapNhatTrangThai.Name = "cboCapNhatTrangThai";
            this.cboCapNhatTrangThai.Size = new System.Drawing.Size(130, 21);
            this.cboCapNhatTrangThai.TabIndex = 7;
            // 
            // btnDoiTrangThai
            // 
            this.btnDoiTrangThai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDoiTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiTrangThai.Location = new System.Drawing.Point(760, 12);
            this.btnDoiTrangThai.Name = "btnDoiTrangThai";
            this.btnDoiTrangThai.Size = new System.Drawing.Size(130, 26);
            this.btnDoiTrangThai.TabIndex = 6;
            this.btnDoiTrangThai.Text = "Chuyển Trạng Thái";
            this.btnDoiTrangThai.UseVisualStyleBackColor = false;
            this.btnDoiTrangThai.Click += new System.EventHandler(this.btnDoiTrangThai_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(10, 50);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(880, 475);
            this.dgvTask.TabIndex = 5;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // btnLocTask
            // 
            this.btnLocTask.Location = new System.Drawing.Point(475, 13);
            this.btnLocTask.Name = "btnLocTask";
            this.btnLocTask.Size = new System.Drawing.Size(75, 25);
            this.btnLocTask.TabIndex = 4;
            this.btnLocTask.Text = "Lọc Task";
            this.btnLocTask.UseVisualStyleBackColor = true;
            this.btnLocTask.Click += new System.EventHandler(this.btnLocTask_Click);
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.FormattingEnabled = true;
            this.cboStatusFilter.Items.AddRange(new object[] {
            "Tất cả",
            "To Do",
            "In Progress",
            "Review",
            "Done"});
            this.cboStatusFilter.Location = new System.Drawing.Point(340, 15);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(120, 21);
            this.cboStatusFilter.TabIndex = 3;
            // 
            // cboDuAnFilter
            // 
            this.cboDuAnFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDuAnFilter.FormattingEnabled = true;
            this.cboDuAnFilter.Location = new System.Drawing.Point(60, 15);
            this.cboDuAnFilter.Name = "cboDuAnFilter";
            this.cboDuAnFilter.Size = new System.Drawing.Size(200, 21);
            this.cboDuAnFilter.TabIndex = 1;
            this.cboDuAnFilter.SelectedIndexChanged += new System.EventHandler(this.cboDuAnFilter_SelectedIndexChanged);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Location = new System.Drawing.Point(275, 18);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(58, 13);
            this.lblStatusFilter.TabIndex = 2;
            this.lblStatusFilter.Text = "Trạng thái:";
            // 
            // lblDuAnFilter
            // 
            this.lblDuAnFilter.AutoSize = true;
            this.lblDuAnFilter.Location = new System.Drawing.Point(10, 18);
            this.lblDuAnFilter.Name = "lblDuAnFilter";
            this.lblDuAnFilter.Size = new System.Drawing.Size(39, 13);
            this.lblDuAnFilter.TabIndex = 0;
            this.lblDuAnFilter.Text = "Dự án:";
            // 
            // tabTaoTask
            // 
            this.tabTaoTask.Controls.Add(this.btnTaoTask);
            this.tabTaoTask.Controls.Add(this.chkListThanhVien);
            this.tabTaoTask.Controls.Add(this.lblPhanCong);
            this.tabTaoTask.Controls.Add(this.cboTrangThaiTask);
            this.tabTaoTask.Controls.Add(this.cboDoUuTien);
            this.tabTaoTask.Controls.Add(this.dtpHanNop);
            this.tabTaoTask.Controls.Add(this.txtMoTa);
            this.tabTaoTask.Controls.Add(this.txtTenTask);
            this.tabTaoTask.Controls.Add(this.cboDuAnTaoTask);
            this.tabTaoTask.Controls.Add(this.lblTrangThai);
            this.tabTaoTask.Controls.Add(this.lblDoUuTien);
            this.tabTaoTask.Controls.Add(this.lblHanNop);
            this.tabTaoTask.Controls.Add(this.lblMoTa);
            this.tabTaoTask.Controls.Add(this.lblTenTask);
            this.tabTaoTask.Controls.Add(this.lblDuAnTao);
            this.tabTaoTask.Location = new System.Drawing.Point(4, 22);
            this.tabTaoTask.Name = "tabTaoTask";
            this.tabTaoTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaoTask.Size = new System.Drawing.Size(906, 535);
            this.tabTaoTask.TabIndex = 1;
            this.tabTaoTask.Text = "Tạo Task & Phân Công (SqlTransaction)";
            this.tabTaoTask.UseVisualStyleBackColor = true;
            // 
            // btnTaoTask
            // 
            this.btnTaoTask.BackColor = System.Drawing.Color.LightGreen;
            this.btnTaoTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTask.Location = new System.Drawing.Point(100, 440);
            this.btnTaoTask.Name = "btnTaoTask";
            this.btnTaoTask.Size = new System.Drawing.Size(200, 40);
            this.btnTaoTask.TabIndex = 14;
            this.btnTaoTask.Text = "Tạo Task && Phân Công";
            this.btnTaoTask.UseVisualStyleBackColor = false;
            this.btnTaoTask.Click += new System.EventHandler(this.btnTaoTask_Click);
            // 
            // chkListThanhVien
            // 
            this.chkListThanhVien.FormattingEnabled = true;
            this.chkListThanhVien.Location = new System.Drawing.Point(460, 50);
            this.chkListThanhVien.Name = "chkListThanhVien";
            this.chkListThanhVien.Size = new System.Drawing.Size(400, 364);
            this.chkListThanhVien.TabIndex = 13;
            // 
            // lblPhanCong
            // 
            this.lblPhanCong.AutoSize = true;
            this.lblPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanCong.Location = new System.Drawing.Point(460, 20);
            this.lblPhanCong.Name = "lblPhanCong";
            this.lblPhanCong.Size = new System.Drawing.Size(189, 13);
            this.lblPhanCong.TabIndex = 12;
            this.lblPhanCong.Text = "Chọn Thành Viên Được Giao Việc:";
            // 
            // cboTrangThaiTask
            // 
            this.cboTrangThaiTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiTask.FormattingEnabled = true;
            this.cboTrangThaiTask.Items.AddRange(new object[] {
            "To Do",
            "In Progress",
            "Review",
            "Done"});
            this.cboTrangThaiTask.Location = new System.Drawing.Point(100, 370);
            this.cboTrangThaiTask.Name = "cboTrangThaiTask";
            this.cboTrangThaiTask.Size = new System.Drawing.Size(320, 21);
            this.cboTrangThaiTask.TabIndex = 11;
            // 
            // cboDoUuTien
            // 
            this.cboDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoUuTien.FormattingEnabled = true;
            this.cboDoUuTien.Items.AddRange(new object[] {
            "Cao",
            "Trung bình",
            "Thấp"});
            this.cboDoUuTien.Location = new System.Drawing.Point(100, 330);
            this.cboDoUuTien.Name = "cboDoUuTien";
            this.cboDoUuTien.Size = new System.Drawing.Size(320, 21);
            this.cboDoUuTien.TabIndex = 10;
            // 
            // dtpHanNop
            // 
            this.dtpHanNop.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpHanNop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanNop.Location = new System.Drawing.Point(100, 290);
            this.dtpHanNop.Name = "dtpHanNop";
            this.dtpHanNop.Size = new System.Drawing.Size(320, 20);
            this.dtpHanNop.TabIndex = 9;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(100, 100);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(320, 170);
            this.txtMoTa.TabIndex = 8;
            // 
            // txtTenTask
            // 
            this.txtTenTask.Location = new System.Drawing.Point(100, 60);
            this.txtTenTask.Name = "txtTenTask";
            this.txtTenTask.Size = new System.Drawing.Size(320, 20);
            this.txtTenTask.TabIndex = 7;
            // 
            // cboDuAnTaoTask
            // 
            this.cboDuAnTaoTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDuAnTaoTask.FormattingEnabled = true;
            this.cboDuAnTaoTask.Location = new System.Drawing.Point(100, 20);
            this.cboDuAnTaoTask.Name = "cboDuAnTaoTask";
            this.cboDuAnTaoTask.Size = new System.Drawing.Size(320, 21);
            this.cboDuAnTaoTask.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(20, 373);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(58, 13);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblDoUuTien
            // 
            this.lblDoUuTien.AutoSize = true;
            this.lblDoUuTien.Location = new System.Drawing.Point(20, 333);
            this.lblDoUuTien.Name = "lblDoUuTien";
            this.lblDoUuTien.Size = new System.Drawing.Size(58, 13);
            this.lblDoUuTien.TabIndex = 4;
            this.lblDoUuTien.Text = "Độ ưu tiên:";
            // 
            // lblHanNop
            // 
            this.lblHanNop.AutoSize = true;
            this.lblHanNop.Location = new System.Drawing.Point(20, 293);
            this.lblHanNop.Name = "lblHanNop";
            this.lblHanNop.Size = new System.Drawing.Size(51, 13);
            this.lblHanNop.TabIndex = 3;
            this.lblHanNop.Text = "Hạn nộp:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(20, 103);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(37, 13);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblTenTask
            // 
            this.lblTenTask.AutoSize = true;
            this.lblTenTask.Location = new System.Drawing.Point(20, 63);
            this.lblTenTask.Name = "lblTenTask";
            this.lblTenTask.Size = new System.Drawing.Size(53, 13);
            this.lblTenTask.TabIndex = 1;
            this.lblTenTask.Text = "Tên Task:";
            // 
            // lblDuAnTao
            // 
            this.lblDuAnTao.AutoSize = true;
            this.lblDuAnTao.Location = new System.Drawing.Point(20, 23);
            this.lblDuAnTao.Name = "lblDuAnTao";
            this.lblDuAnTao.Size = new System.Drawing.Size(64, 13);
            this.lblDuAnTao.TabIndex = 0;
            this.lblDuAnTao.Text = "Chọn dự án:";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.dgvThongKeThanhVien);
            this.tabBaoCao.Controls.Add(this.lblTienDoTong);
            this.tabBaoCao.Controls.Add(this.lstTaskTreHan);
            this.tabBaoCao.Controls.Add(this.lblCanhBaoTreHan);
            this.tabBaoCao.Location = new System.Drawing.Point(4, 22);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(906, 535);
            this.tabBaoCao.TabIndex = 2;
            this.tabBaoCao.Text = "Cảnh Báo Trễ Hạn & Báo Cáo Tiến Độ";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // dgvThongKeThanhVien
            // 
            this.dgvThongKeThanhVien.AllowUserToAddRows = false;
            this.dgvThongKeThanhVien.AllowUserToDeleteRows = false;
            this.dgvThongKeThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeThanhVien.Location = new System.Drawing.Point(15, 270);
            this.dgvThongKeThanhVien.Name = "dgvThongKeThanhVien";
            this.dgvThongKeThanhVien.ReadOnly = true;
            this.dgvThongKeThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeThanhVien.Size = new System.Drawing.Size(875, 250);
            this.dgvThongKeThanhVien.TabIndex = 3;
            // 
            // lblTienDoTong
            // 
            this.lblTienDoTong.AutoSize = true;
            this.lblTienDoTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDoTong.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTienDoTong.Location = new System.Drawing.Point(15, 235);
            this.lblTienDoTong.Name = "lblTienDoTong";
            this.lblTienDoTong.Size = new System.Drawing.Size(242, 18);
            this.lblTienDoTong.TabIndex = 2;
            this.lblTienDoTong.Text = "Tỷ lệ hoàn thành dự án: 0.00%";
            // 
            // lstTaskTreHan
            // 
            this.lstTaskTreHan.ForeColor = System.Drawing.Color.Red;
            this.lstTaskTreHan.FormattingEnabled = true;
            this.lstTaskTreHan.Location = new System.Drawing.Point(15, 45);
            this.lstTaskTreHan.Name = "lstTaskTreHan";
            this.lstTaskTreHan.Size = new System.Drawing.Size(875, 173);
            this.lstTaskTreHan.TabIndex = 1;
            // 
            // lblCanhBaoTreHan
            // 
            this.lblCanhBaoTreHan.AutoSize = true;
            this.lblCanhBaoTreHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhBaoTreHan.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBaoTreHan.Location = new System.Drawing.Point(15, 20);
            this.lblCanhBaoTreHan.Name = "lblCanhBaoTreHan";
            this.lblCanhBaoTreHan.Size = new System.Drawing.Size(325, 16);
            this.lblCanhBaoTreHan.TabIndex = 0;
            this.lblCanhBaoTreHan.Text = "CẢNH BÁO TRỄ HẠN (SqlDataReader Read):";
            // 
            // frmProjectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.tabMain);
            this.Name = "frmProjectTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Công Việc & Tiến Độ Dự Án (Project & Task Management)";
            this.Load += new System.EventHandler(this.frmProjectTask_Load);
            this.tabMain.ResumeLayout(false);
            this.tabKanban.ResumeLayout(false);
            this.tabKanban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.tabTaoTask.ResumeLayout(false);
            this.tabTaoTask.PerformLayout();
            this.tabBaoCao.ResumeLayout(false);
            this.tabBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKanban;
        private System.Windows.Forms.TabPage tabTaoTask;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.Label lblDuAnFilter;
        private System.Windows.Forms.ComboBox cboDuAnFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Button btnLocTask;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.ComboBox cboCapNhatTrangThai;
        private System.Windows.Forms.Button btnDoiTrangThai;
        private System.Windows.Forms.Label lblDuAnTao;
        private System.Windows.Forms.ComboBox cboDuAnTaoTask;
        private System.Windows.Forms.Label lblTenTask;
        private System.Windows.Forms.TextBox txtTenTask;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblHanNop;
        private System.Windows.Forms.DateTimePicker dtpHanNop;
        private System.Windows.Forms.Label lblDoUuTien;
        private System.Windows.Forms.ComboBox cboDoUuTien;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThaiTask;
        private System.Windows.Forms.Label lblPhanCong;
        private System.Windows.Forms.CheckedListBox chkListThanhVien;
        private System.Windows.Forms.Button btnTaoTask;
        private System.Windows.Forms.Label lblCanhBaoTreHan;
        private System.Windows.Forms.ListBox lstTaskTreHan;
        private System.Windows.Forms.Label lblTienDoTong;
        private System.Windows.Forms.DataGridView dgvThongKeThanhVien;
    }
}