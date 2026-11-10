namespace GarageSystem.GUI
{
    partial class frmGarage
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
            this.tabPhieuSua = new System.Windows.Forms.TabPage();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvPhieuChuaTT = new System.Windows.Forms.DataGridView();
            this.grpLapPhieu = new System.Windows.Forms.GroupBox();
            this.lblTongTienPhieu = new System.Windows.Forms.Label();
            this.lblTongTienTxt = new System.Windows.Forms.Label();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dgvChiTietSua = new System.Windows.Forms.DataGridView();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.nudTienCong = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuongPT = new System.Windows.Forms.NumericUpDown();
            this.cboPhuTung = new System.Windows.Forms.ComboBox();
            this.txtNoiDungSua = new System.Windows.Forms.TextBox();
            this.lblTienCong = new System.Windows.Forms.Label();
            this.lblSoLuongPT = new System.Windows.Forms.Label();
            this.lblPhuTung = new System.Windows.Forms.Label();
            this.lblNoiDungSua = new System.Windows.Forms.Label();
            this.grpTiepNhan = new System.Windows.Forms.GroupBox();
            this.btnTiepNhanMoi = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.nudNamSX = new System.Windows.Forms.NumericUpDown();
            this.lblNamSX = new System.Windows.Forms.Label();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.lblHieuXe = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.btnTimXe = new System.Windows.Forms.Button();
            this.txtTimBienSo = new System.Windows.Forms.TextBox();
            this.lblTimBienSo = new System.Windows.Forms.Label();
            this.tabPhuTung = new System.Windows.Forms.TabPage();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.nudSoLuongTonPT = new System.Windows.Forms.NumericUpDown();
            this.nudDonGiaPT = new System.Windows.Forms.NumericUpDown();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.lblSoLuongTonPT = new System.Windows.Forms.Label();
            this.lblDonGiaPT = new System.Windows.Forms.Label();
            this.lblTenPT = new System.Windows.Forms.Label();
            this.dgvPhuTungKho = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.tabPhieuSua.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChuaTT)).BeginInit();
            this.grpLapPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongPT)).BeginInit();
            this.grpTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamSX)).BeginInit();
            this.tabPhuTung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTonPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTungKho)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPhieuSua);
            this.tabMain.Controls.Add(this.tabPhuTung);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(934, 581);
            this.tabMain.TabIndex = 0;
            // 
            // tabPhieuSua
            // 
            this.tabPhieuSua.Controls.Add(this.grpThanhToan);
            this.tabPhieuSua.Controls.Add(this.grpLapPhieu);
            this.tabPhieuSua.Controls.Add(this.grpTiepNhan);
            this.tabPhieuSua.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuSua.Name = "tabPhieuSua";
            this.tabPhieuSua.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuSua.Size = new System.Drawing.Size(926, 555);
            this.tabPhieuSua.TabIndex = 0;
            this.tabPhieuSua.Text = "Tiếp Nhận Xe & Lập Phiếu Sửa Chữa";
            this.tabPhieuSua.UseVisualStyleBackColor = true;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.Controls.Add(this.dgvPhieuChuaTT);
            this.grpThanhToan.Location = new System.Drawing.Point(460, 310);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(455, 235);
            this.grpThanhToan.TabIndex = 2;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh Toán & Xuất Hóa Đơn Dịch Vụ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Coral;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(310, 190);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 35);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán HD";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvPhieuChuaTT
            // 
            this.dgvPhieuChuaTT.AllowUserToAddRows = false;
            this.dgvPhieuChuaTT.AllowUserToDeleteRows = false;
            this.dgvPhieuChuaTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuChuaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChuaTT.Location = new System.Drawing.Point(10, 25);
            this.dgvPhieuChuaTT.Name = "dgvPhieuChuaTT";
            this.dgvPhieuChuaTT.ReadOnly = true;
            this.dgvPhieuChuaTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuChuaTT.Size = new System.Drawing.Size(435, 155);
            this.dgvPhieuChuaTT.TabIndex = 0;
            // 
            // grpLapPhieu
            // 
            this.grpLapPhieu.Controls.Add(this.lblTongTienPhieu);
            this.grpLapPhieu.Controls.Add(this.lblTongTienTxt);
            this.grpLapPhieu.Controls.Add(this.btnLapPhieu);
            this.grpLapPhieu.Controls.Add(this.dgvChiTietSua);
            this.grpLapPhieu.Controls.Add(this.btnThemChiTiet);
            this.grpLapPhieu.Controls.Add(this.nudTienCong);
            this.grpLapPhieu.Controls.Add(this.nudSoLuongPT);
            this.grpLapPhieu.Controls.Add(this.cboPhuTung);
            this.grpLapPhieu.Controls.Add(this.txtNoiDungSua);
            this.grpLapPhieu.Controls.Add(this.lblTienCong);
            this.grpLapPhieu.Controls.Add(this.lblSoLuongPT);
            this.grpLapPhieu.Controls.Add(this.lblPhuTung);
            this.grpLapPhieu.Controls.Add(this.lblNoiDungSua);
            this.grpLapPhieu.Location = new System.Drawing.Point(460, 10);
            this.grpLapPhieu.Name = "grpLapPhieu";
            this.grpLapPhieu.Size = new System.Drawing.Size(455, 290);
            this.grpLapPhieu.TabIndex = 1;
            this.grpLapPhieu.TabStop = false;
            this.grpLapPhieu.Text = "Lập Phiếu Sửa Chữa (SqlTransaction)";
            // 
            // lblTongTienPhieu
            // 
            this.lblTongTienPhieu.AutoSize = true;
            this.lblTongTienPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPhieu.ForeColor = System.Drawing.Color.Red;
            this.lblTongTienPhieu.Location = new System.Drawing.Point(90, 255);
            this.lblTongTienPhieu.Name = "lblTongTienPhieu";
            this.lblTongTienPhieu.Size = new System.Drawing.Size(58, 18);
            this.lblTongTienPhieu.TabIndex = 12;
            this.lblTongTienPhieu.Text = "0 VNĐ";
            // 
            // lblTongTienTxt
            // 
            this.lblTongTienTxt.AutoSize = true;
            this.lblTongTienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTxt.Location = new System.Drawing.Point(10, 257);
            this.lblTongTienTxt.Name = "lblTongTienTxt";
            this.lblTongTienTxt.Size = new System.Drawing.Size(71, 15);
            this.lblTongTienTxt.TabIndex = 11;
            this.lblTongTienTxt.Text = "Tổng tiền:";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.Location = new System.Drawing.Point(295, 248);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(150, 32);
            this.btnLapPhieu.TabIndex = 10;
            this.btnLapPhieu.Text = "Tạo Phiếu && Trừ Kho";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dgvChiTietSua
            // 
            this.dgvChiTietSua.AllowUserToAddRows = false;
            this.dgvChiTietSua.AllowUserToDeleteRows = false;
            this.dgvChiTietSua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietSua.Location = new System.Drawing.Point(10, 115);
            this.dgvChiTietSua.Name = "dgvChiTietSua";
            this.dgvChiTietSua.ReadOnly = true;
            this.dgvChiTietSua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietSua.Size = new System.Drawing.Size(435, 125);
            this.dgvChiTietSua.TabIndex = 9;
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(345, 80);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(100, 25);
            this.btnThemChiTiet.TabIndex = 8;
            this.btnThemChiTiet.Text = "Thêm Phụ Tùng";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // nudTienCong
            // 
            this.nudTienCong.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.nudTienCong.Location = new System.Drawing.Point(235, 83);
            this.nudTienCong.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudTienCong.Name = "nudTienCong";
            this.nudTienCong.Size = new System.Drawing.Size(100, 20);
            this.nudTienCong.TabIndex = 7;
            // 
            // nudSoLuongPT
            // 
            this.nudSoLuongPT.Location = new System.Drawing.Point(70, 83);
            this.nudSoLuongPT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongPT.Name = "nudSoLuongPT";
            this.nudSoLuongPT.Size = new System.Drawing.Size(50, 20);
            this.nudSoLuongPT.TabIndex = 6;
            this.nudSoLuongPT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboPhuTung
            // 
            this.cboPhuTung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuTung.FormattingEnabled = true;
            this.cboPhuTung.Location = new System.Drawing.Point(70, 50);
            this.cboPhuTung.Name = "cboPhuTung";
            this.cboPhuTung.Size = new System.Drawing.Size(375, 21);
            this.cboPhuTung.TabIndex = 5;
            // 
            // txtNoiDungSua
            // 
            this.txtNoiDungSua.Location = new System.Drawing.Point(90, 20);
            this.txtNoiDungSua.Name = "txtNoiDungSua";
            this.txtNoiDungSua.Size = new System.Drawing.Size(355, 20);
            this.txtNoiDungSua.TabIndex = 4;
            // 
            // lblTienCong
            // 
            this.lblTienCong.AutoSize = true;
            this.lblTienCong.Location = new System.Drawing.Point(170, 85);
            this.lblTienCong.Name = "lblTienCong";
            this.lblTienCong.Size = new System.Drawing.Size(58, 13);
            this.lblTienCong.TabIndex = 3;
            this.lblTienCong.Text = "Tiền công:";
            // 
            // lblSoLuongPT
            // 
            this.lblSoLuongPT.AutoSize = true;
            this.lblSoLuongPT.Location = new System.Drawing.Point(10, 85);
            this.lblSoLuongPT.Name = "lblSoLuongPT";
            this.lblSoLuongPT.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuongPT.TabIndex = 2;
            this.lblSoLuongPT.Text = "Số lượng:";
            // 
            // lblPhuTung
            // 
            this.lblPhuTung.AutoSize = true;
            this.lblPhuTung.Location = new System.Drawing.Point(10, 53);
            this.lblPhuTung.Name = "lblPhuTung";
            this.lblPhuTung.Size = new System.Drawing.Size(53, 13);
            this.lblPhuTung.TabIndex = 1;
            this.lblPhuTung.Text = "Phụ tùng:";
            // 
            // lblNoiDungSua
            // 
            this.lblNoiDungSua.AutoSize = true;
            this.lblNoiDungSua.Location = new System.Drawing.Point(10, 23);
            this.lblNoiDungSua.Name = "lblNoiDungSua";
            this.lblNoiDungSua.Size = new System.Drawing.Size(73, 13);
            this.lblNoiDungSua.TabIndex = 0;
            this.lblNoiDungSua.Text = "Nội dung sửa:";
            // 
            // grpTiepNhan
            // 
            this.grpTiepNhan.Controls.Add(this.btnTiepNhanMoi);
            this.grpTiepNhan.Controls.Add(this.txtDiaChi);
            this.grpTiepNhan.Controls.Add(this.lblDiaChi);
            this.grpTiepNhan.Controls.Add(this.nudNamSX);
            this.grpTiepNhan.Controls.Add(this.lblNamSX);
            this.grpTiepNhan.Controls.Add(this.txtHieuXe);
            this.grpTiepNhan.Controls.Add(this.lblHieuXe);
            this.grpTiepNhan.Controls.Add(this.txtDienThoai);
            this.grpTiepNhan.Controls.Add(this.lblDienThoai);
            this.grpTiepNhan.Controls.Add(this.txtTenKH);
            this.grpTiepNhan.Controls.Add(this.lblTenKH);
            this.grpTiepNhan.Controls.Add(this.txtBienSo);
            this.grpTiepNhan.Controls.Add(this.lblBienSo);
            this.grpTiepNhan.Controls.Add(this.btnTimXe);
            this.grpTiepNhan.Controls.Add(this.txtTimBienSo);
            this.grpTiepNhan.Controls.Add(this.lblTimBienSo);
            this.grpTiepNhan.Location = new System.Drawing.Point(10, 10);
            this.grpTiepNhan.Name = "grpTiepNhan";
            this.grpTiepNhan.Size = new System.Drawing.Size(440, 535);
            this.grpTiepNhan.TabIndex = 0;
            this.grpTiepNhan.TabStop = false;
            this.grpTiepNhan.Text = "Tra Cứu & Tiếp Nhận Xe Ô Tô";
            // 
            // btnTiepNhanMoi
            // 
            this.btnTiepNhanMoi.BackColor = System.Drawing.Color.LightGreen;
            this.btnTiepNhanMoi.Enabled = false;
            this.btnTiepNhanMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhanMoi.Location = new System.Drawing.Point(100, 290);
            this.btnTiepNhanMoi.Name = "btnTiepNhanMoi";
            this.btnTiepNhanMoi.Size = new System.Drawing.Size(325, 35);
            this.btnTiepNhanMoi.TabIndex = 15;
            this.btnTiepNhanMoi.Text = "Tiếp Nhận Xe Mới && Chủ Xe Mới";
            this.btnTiepNhanMoi.UseVisualStyleBackColor = false;
            this.btnTiepNhanMoi.Click += new System.EventHandler(this.btnTiepNhanMoi_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 180);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(325, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 183);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 13;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // nudNamSX
            // 
            this.nudNamSX.Location = new System.Drawing.Point(100, 250);
            this.nudNamSX.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            this.nudNamSX.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            this.nudNamSX.Name = "nudNamSX";
            this.nudNamSX.Size = new System.Drawing.Size(150, 20);
            this.nudNamSX.TabIndex = 12;
            this.nudNamSX.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Location = new System.Drawing.Point(15, 253);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(75, 13);
            this.lblNamSX.TabIndex = 11;
            this.lblNamSX.Text = "Năm sản xuất:";
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(100, 215);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(325, 20);
            this.txtHieuXe.TabIndex = 10;
            // 
            // lblHieuXe
            // 
            this.lblHieuXe.AutoSize = true;
            this.lblHieuXe.Location = new System.Drawing.Point(15, 218);
            this.lblHieuXe.Name = "lblHieuXe";
            this.lblHieuXe.Size = new System.Drawing.Size(46, 13);
            this.lblHieuXe.TabIndex = 9;
            this.lblHieuXe.Text = "Hiệu xe:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(100, 145);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(325, 20);
            this.txtDienThoai.TabIndex = 8;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(15, 148);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(58, 13);
            this.lblDienThoai.TabIndex = 7;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(100, 110);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(325, 20);
            this.txtTenKH.TabIndex = 6;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(15, 113);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(66, 13);
            this.lblTenKH.TabIndex = 5;
            this.lblTenKH.Text = "Tên chủ xe:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(100, 75);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(325, 20);
            this.txtBienSo.TabIndex = 4;
            // 
            // lblBienSo
            // 
            this.lblBienSo.AutoSize = true;
            this.lblBienSo.Location = new System.Drawing.Point(15, 78);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(60, 13);
            this.lblBienSo.TabIndex = 3;
            this.lblBienSo.Text = "Biển số xe:";
            // 
            // btnTimXe
            // 
            this.btnTimXe.Location = new System.Drawing.Point(340, 25);
            this.btnTimXe.Name = "btnTimXe";
            this.btnTimXe.Size = new System.Drawing.Size(85, 25);
            this.btnTimXe.TabIndex = 2;
            this.btnTimXe.Text = "Tra cứu";
            this.btnTimXe.UseVisualStyleBackColor = true;
            this.btnTimXe.Click += new System.EventHandler(this.btnTimXe_Click);
            // 
            // txtTimBienSo
            // 
            this.txtTimBienSo.Location = new System.Drawing.Point(100, 27);
            this.txtTimBienSo.Name = "txtTimBienSo";
            this.txtTimBienSo.Size = new System.Drawing.Size(230, 20);
            this.txtTimBienSo.TabIndex = 1;
            // 
            // lblTimBienSo
            // 
            this.lblTimBienSo.AutoSize = true;
            this.lblTimBienSo.Location = new System.Drawing.Point(15, 30);
            this.lblTimBienSo.Name = "lblTimBienSo";
            this.lblTimBienSo.Size = new System.Drawing.Size(63, 13);
            this.lblTimBienSo.TabIndex = 0;
            this.lblTimBienSo.Text = "Tìm biển số:";
            // 
            // tabPhuTung
            // 
            this.tabPhuTung.Controls.Add(this.btnThemPT);
            this.tabPhuTung.Controls.Add(this.nudSoLuongTonPT);
            this.tabPhuTung.Controls.Add(this.nudDonGiaPT);
            this.tabPhuTung.Controls.Add(this.txtTenPT);
            this.tabPhuTung.Controls.Add(this.lblSoLuongTonPT);
            this.tabPhuTung.Controls.Add(this.lblDonGiaPT);
            this.tabPhuTung.Controls.Add(this.lblTenPT);
            this.tabPhuTung.Controls.Add(this.dgvPhuTungKho);
            this.tabPhuTung.Location = new System.Drawing.Point(4, 22);
            this.tabPhuTung.Name = "tabPhuTung";
            this.tabPhuTung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhuTung.Size = new System.Drawing.Size(926, 555);
            this.tabPhuTung.TabIndex = 1;
            this.tabPhuTung.Text = "Quản Lý Kho Phụ Tùng";
            this.tabPhuTung.UseVisualStyleBackColor = true;
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(340, 50);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(100, 30);
            this.btnThemPT.TabIndex = 7;
            this.btnThemPT.Text = "Thêm Phụ Tùng";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // nudSoLuongTonPT
            // 
            this.nudSoLuongTonPT.Location = new System.Drawing.Point(100, 80);
            this.nudSoLuongTonPT.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSoLuongTonPT.Name = "nudSoLuongTonPT";
            this.nudSoLuongTonPT.Size = new System.Drawing.Size(200, 20);
            this.nudSoLuongTonPT.TabIndex = 6;
            // 
            // nudDonGiaPT
            // 
            this.nudDonGiaPT.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudDonGiaPT.Location = new System.Drawing.Point(100, 50);
            this.nudDonGiaPT.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudDonGiaPT.Name = "nudDonGiaPT";
            this.nudDonGiaPT.Size = new System.Drawing.Size(200, 20);
            this.nudDonGiaPT.TabIndex = 5;
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(100, 20);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(340, 20);
            this.txtTenPT.TabIndex = 4;
            // 
            // lblSoLuongTonPT
            // 
            this.lblSoLuongTonPT.AutoSize = true;
            this.lblSoLuongTonPT.Location = new System.Drawing.Point(15, 83);
            this.lblSoLuongTonPT.Name = "lblSoLuongTonPT";
            this.lblSoLuongTonPT.Size = new System.Drawing.Size(70, 13);
            this.lblSoLuongTonPT.TabIndex = 3;
            this.lblSoLuongTonPT.Text = "Số lượng tồn:";
            // 
            // lblDonGiaPT
            // 
            this.lblDonGiaPT.AutoSize = true;
            this.lblDonGiaPT.Location = new System.Drawing.Point(15, 53);
            this.lblDonGiaPT.Name = "lblDonGiaPT";
            this.lblDonGiaPT.Size = new System.Drawing.Size(47, 13);
            this.lblDonGiaPT.TabIndex = 2;
            this.lblDonGiaPT.Text = "Đơn giá:";
            // 
            // lblTenPT
            // 
            this.lblTenPT.AutoSize = true;
            this.lblTenPT.Location = new System.Drawing.Point(15, 23);
            this.lblTenPT.Name = "lblTenPT";
            this.lblTenPT.Size = new System.Drawing.Size(74, 13);
            this.lblTenPT.TabIndex = 1;
            this.lblTenPT.Text = "Tên phụ tùng:";
            // 
            // dgvPhuTungKho
            // 
            this.dgvPhuTungKho.AllowUserToAddRows = false;
            this.dgvPhuTungKho.AllowUserToDeleteRows = false;
            this.dgvPhuTungKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuTungKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTungKho.Location = new System.Drawing.Point(10, 120);
            this.dgvPhuTungKho.Name = "dgvPhuTungKho";
            this.dgvPhuTungKho.ReadOnly = true;
            this.dgvPhuTungKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuTungKho.Size = new System.Drawing.Size(900, 425);
            this.dgvPhuTungKho.TabIndex = 0;
            // 
            // frmGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 581);
            this.Controls.Add(this.tabMain);
            this.Name = "frmGarage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Garage Và Bảo Dưỡng Xe Ô Tô (Garage Management System)";
            this.Load += new System.EventHandler(this.frmGarage_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPhieuSua.ResumeLayout(false);
            this.grpThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChuaTT)).EndInit();
            this.grpLapPhieu.ResumeLayout(false);
            this.grpLapPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongPT)).EndInit();
            this.grpTiepNhan.ResumeLayout(false);
            this.grpTiepNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamSX)).EndInit();
            this.tabPhuTung.ResumeLayout(false);
            this.tabPhuTung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTonPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTungKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPhieuSua;
        private System.Windows.Forms.TabPage tabPhuTung;
        private System.Windows.Forms.GroupBox grpTiepNhan;
        private System.Windows.Forms.Label lblTimBienSo;
        private System.Windows.Forms.TextBox txtTimBienSo;
        private System.Windows.Forms.Button btnTimXe;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblHieuXe;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.Label lblNamSX;
        private System.Windows.Forms.NumericUpDown nudNamSX;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTiepNhanMoi;
        private System.Windows.Forms.GroupBox grpLapPhieu;
        private System.Windows.Forms.Label lblNoiDungSua;
        private System.Windows.Forms.TextBox txtNoiDungSua;
        private System.Windows.Forms.Label lblPhuTung;
        private System.Windows.Forms.ComboBox cboPhuTung;
        private System.Windows.Forms.Label lblSoLuongPT;
        private System.Windows.Forms.NumericUpDown nudSoLuongPT;
        private System.Windows.Forms.Label lblTienCong;
        private System.Windows.Forms.NumericUpDown nudTienCong;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTietSua;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblTongTienTxt;
        private System.Windows.Forms.Label lblTongTienPhieu;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.DataGridView dgvPhieuChuaTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvPhuTungKho;
        private System.Windows.Forms.Label lblTenPT;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.Label lblDonGiaPT;
        private System.Windows.Forms.NumericUpDown nudDonGiaPT;
        private System.Windows.Forms.Label lblSoLuongTonPT;
        private System.Windows.Forms.NumericUpDown nudSoLuongTonPT;
        private System.Windows.Forms.Button btnThemPT;
    }
}
