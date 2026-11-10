namespace KaraokeManagement.GUI
{
    partial class frmKaraoke
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
            this.flpPhongHat = new System.Windows.Forms.FlowLayoutPanel();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.btnCapNhatGiaoDien = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienTxt = new System.Windows.Forms.Label();
            this.lblTienDichVu = new System.Windows.Forms.Label();
            this.lblTienDichVuTxt = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblTienPhongTxt = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.lblGioVaoTxt = new System.Windows.Forms.Label();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblGiaPhongTxt = new System.Windows.Forms.Label();
            this.lblTenPhongDangChon = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnMoPhong = new System.Windows.Forms.Button();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.nudSoLuongDV = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongDV = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblChonDV = new System.Windows.Forms.Label();
            this.grpChiTiet.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongDV)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPhongHat
            // 
            this.flpPhongHat.AutoScroll = true;
            this.flpPhongHat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPhongHat.Location = new System.Drawing.Point(12, 12);
            this.flpPhongHat.Name = "flpPhongHat";
            this.flpPhongHat.Size = new System.Drawing.Size(420, 530);
            this.flpPhongHat.TabIndex = 0;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.btnCapNhatGiaoDien);
            this.grpChiTiet.Controls.Add(this.lblTongTien);
            this.grpChiTiet.Controls.Add(this.lblTongTienTxt);
            this.grpChiTiet.Controls.Add(this.lblTienDichVu);
            this.grpChiTiet.Controls.Add(this.lblTienDichVuTxt);
            this.grpChiTiet.Controls.Add(this.lblTienPhong);
            this.grpChiTiet.Controls.Add(this.lblTienPhongTxt);
            this.grpChiTiet.Controls.Add(this.lblGioVao);
            this.grpChiTiet.Controls.Add(this.lblGioVaoTxt);
            this.grpChiTiet.Controls.Add(this.lblGiaPhong);
            this.grpChiTiet.Controls.Add(this.lblGiaPhongTxt);
            this.grpChiTiet.Controls.Add(this.lblTenPhongDangChon);
            this.grpChiTiet.Controls.Add(this.btnThanhToan);
            this.grpChiTiet.Controls.Add(this.btnMoPhong);
            this.grpChiTiet.Location = new System.Drawing.Point(445, 12);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(460, 220);
            this.grpChiTiet.TabIndex = 1;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Thông Tin Phòng && Thanh Toán";
            // 
            // btnCapNhatGiaoDien
            // 
            this.btnCapNhatGiaoDien.Location = new System.Drawing.Point(340, 20);
            this.btnCapNhatGiaoDien.Name = "btnCapNhatGiaoDien";
            this.btnCapNhatGiaoDien.Size = new System.Drawing.Size(110, 25);
            this.btnCapNhatGiaoDien.TabIndex = 13;
            this.btnCapNhatGiaoDien.Text = "Tính lại tiền";
            this.btnCapNhatGiaoDien.UseVisualStyleBackColor = true;
            this.btnCapNhatGiaoDien.Click += new System.EventHandler(this.btnCapNhatGiaoDien_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(115, 175);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 20);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienTxt
            // 
            this.lblTongTienTxt.AutoSize = true;
            this.lblTongTienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTxt.Location = new System.Drawing.Point(15, 177);
            this.lblTongTienTxt.Name = "lblTongTienTxt";
            this.lblTongTienTxt.Size = new System.Drawing.Size(71, 15);
            this.lblTongTienTxt.TabIndex = 11;
            this.lblTongTienTxt.Text = "TỔNG CỘNG:";
            // 
            // lblTienDichVu
            // 
            this.lblTienDichVu.AutoSize = true;
            this.lblTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDichVu.Location = new System.Drawing.Point(115, 145);
            this.lblTienDichVu.Name = "lblTienDichVu";
            this.lblTienDichVu.Size = new System.Drawing.Size(48, 16);
            this.lblTienDichVu.TabIndex = 10;
            this.lblTienDichVu.Text = "0 VNĐ";
            // 
            // lblTienDichVuTxt
            // 
            this.lblTienDichVuTxt.AutoSize = true;
            this.lblTienDichVuTxt.Location = new System.Drawing.Point(15, 147);
            this.lblTienDichVuTxt.Name = "lblTienDichVuTxt";
            this.lblTienDichVuTxt.Size = new System.Drawing.Size(71, 13);
            this.lblTienDichVuTxt.TabIndex = 9;
            this.lblTienDichVuTxt.Text = "Tiền dịch vụ:";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienPhong.Location = new System.Drawing.Point(115, 115);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(48, 16);
            this.lblTienPhong.TabIndex = 8;
            this.lblTienPhong.Text = "0 VNĐ";
            // 
            // lblTienPhongTxt
            // 
            this.lblTienPhongTxt.AutoSize = true;
            this.lblTienPhongTxt.Location = new System.Drawing.Point(15, 117);
            this.lblTienPhongTxt.Name = "lblTienPhongTxt";
            this.lblTienPhongTxt.Size = new System.Drawing.Size(64, 13);
            this.lblTienPhongTxt.TabIndex = 7;
            this.lblTienPhongTxt.Text = "Tiền phòng:";
            // 
            // lblGioVao
            // 
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioVao.Location = new System.Drawing.Point(115, 85);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(35, 15);
            this.lblGioVao.TabIndex = 6;
            this.lblGioVao.Text = "--:--";
            // 
            // lblGioVaoTxt
            // 
            this.lblGioVaoTxt.AutoSize = true;
            this.lblGioVaoTxt.Location = new System.Drawing.Point(15, 87);
            this.lblGioVaoTxt.Name = "lblGioVaoTxt";
            this.lblGioVaoTxt.Size = new System.Drawing.Size(47, 13);
            this.lblGioVaoTxt.TabIndex = 5;
            this.lblGioVaoTxt.Text = "Giờ vào:";
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaPhong.Location = new System.Drawing.Point(115, 55);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(73, 15);
            this.lblGiaPhong.TabIndex = 4;
            this.lblGiaPhong.Text = "0 VNĐ/Giờ";
            // 
            // lblGiaPhongTxt
            // 
            this.lblGiaPhongTxt.AutoSize = true;
            this.lblGiaPhongTxt.Location = new System.Drawing.Point(15, 57);
            this.lblGiaPhongTxt.Name = "lblGiaPhongTxt";
            this.lblGiaPhongTxt.Size = new System.Drawing.Size(59, 13);
            this.lblGiaPhongTxt.TabIndex = 3;
            this.lblGiaPhongTxt.Text = "Giá phòng:";
            // 
            // lblTenPhongDangChon
            // 
            this.lblTenPhongDangChon.AutoSize = true;
            this.lblTenPhongDangChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhongDangChon.ForeColor = System.Drawing.Color.Blue;
            this.lblTenPhongDangChon.Location = new System.Drawing.Point(15, 23);
            this.lblTenPhongDangChon.Name = "lblTenPhongDangChon";
            this.lblTenPhongDangChon.Size = new System.Drawing.Size(148, 20);
            this.lblTenPhongDangChon.TabIndex = 2;
            this.lblTenPhongDangChon.Text = "Chưa chọn phòng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Coral;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(340, 155);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 50);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnMoPhong
            // 
            this.btnMoPhong.BackColor = System.Drawing.Color.LightGreen;
            this.btnMoPhong.Enabled = false;
            this.btnMoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoPhong.Location = new System.Drawing.Point(340, 95);
            this.btnMoPhong.Name = "btnMoPhong";
            this.btnMoPhong.Size = new System.Drawing.Size(110, 50);
            this.btnMoPhong.TabIndex = 0;
            this.btnMoPhong.Text = "Mở Phòng";
            this.btnMoPhong.UseVisualStyleBackColor = false;
            this.btnMoPhong.Click += new System.EventHandler(this.btnMoPhong_Click);
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.dgvDichVu);
            this.grpDichVu.Controls.Add(this.btnThemDV);
            this.grpDichVu.Controls.Add(this.nudSoLuongDV);
            this.grpDichVu.Controls.Add(this.lblSoLuongDV);
            this.grpDichVu.Controls.Add(this.cboDichVu);
            this.grpDichVu.Controls.Add(this.lblChonDV);
            this.grpDichVu.Location = new System.Drawing.Point(445, 240);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(460, 302);
            this.grpDichVu.TabIndex = 2;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Gọi Dịch Vụ && Đồ Uống (Disconnected Model)";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(10, 60);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(440, 230);
            this.dgvDichVu.TabIndex = 5;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Enabled = false;
            this.btnThemDV.Location = new System.Drawing.Point(375, 23);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(75, 25);
            this.btnThemDV.TabIndex = 4;
            this.btnThemDV.Text = "Thêm DV";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // nudSoLuongDV
            // 
            this.nudSoLuongDV.Location = new System.Drawing.Point(305, 25);
            this.nudSoLuongDV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongDV.Name = "nudSoLuongDV";
            this.nudSoLuongDV.Size = new System.Drawing.Size(60, 20);
            this.nudSoLuongDV.TabIndex = 3;
            this.nudSoLuongDV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuongDV
            // 
            this.lblSoLuongDV.AutoSize = true;
            this.lblSoLuongDV.Location = new System.Drawing.Point(250, 28);
            this.lblSoLuongDV.Name = "lblSoLuongDV";
            this.lblSoLuongDV.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuongDV.TabIndex = 2;
            this.lblSoLuongDV.Text = "Số lượng:";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(90, 25);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(150, 21);
            this.cboDichVu.TabIndex = 1;
            // 
            // lblChonDV
            // 
            this.lblChonDV.AutoSize = true;
            this.lblChonDV.Location = new System.Drawing.Point(10, 28);
            this.lblChonDV.Name = "lblChonDV";
            this.lblChonDV.Size = new System.Drawing.Size(71, 13);
            this.lblChonDV.TabIndex = 0;
            this.lblChonDV.Text = "Chọn dịch vụ:";
            // 
            // frmKaraoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 554);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpChiTiet);
            this.Controls.Add(this.flpPhongHat);
            this.Name = "frmKaraoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Đặt Phòng & Dịch Vụ Karaoke (Karaoke Management System)";
            this.Load += new System.EventHandler(this.frmKaraoke_Load);
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPhongHat;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Button btnMoPhong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTenPhongDangChon;
        private System.Windows.Forms.Label lblGiaPhongTxt;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.Label lblGioVaoTxt;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblTienPhongTxt;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblTienDichVuTxt;
        private System.Windows.Forms.Label lblTienDichVu;
        private System.Windows.Forms.Label lblTongTienTxt;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnCapNhatGiaoDien;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.Label lblChonDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblSoLuongDV;
        private System.Windows.Forms.NumericUpDown nudSoLuongDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.DataGridView dgvDichVu;
    }
}
