namespace BaiTap1_ChuDe3
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.mtxtCMND = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.contextMenuMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThemMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaMon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuSinhVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoaSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.cboDinhDang = new System.Windows.Forms.ComboBox();
            this.btnTaiDuLieu = new System.Windows.Forms.Button();
            this.contextMenuMonHoc.SuspendLayout();
            this.contextMenuSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên lót:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ liên lạc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lớp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số ĐT:";
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Location = new System.Drawing.Point(115, 28);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(190, 20);
            this.mtxtMSSV.TabIndex = 0;
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(115, 64);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(190, 20);
            this.txtHoLot.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(418, 64);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(184, 20);
            this.txtTen.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(115, 100);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(190, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(418, 29);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(506, 29);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(418, 100);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(184, 21);
            this.cboLop.TabIndex = 7;
            // 
            // mtxtCMND
            // 
            this.mtxtCMND.Location = new System.Drawing.Point(115, 136);
            this.mtxtCMND.Mask = "000000000";
            this.mtxtCMND.Name = "mtxtCMND";
            this.mtxtCMND.Size = new System.Drawing.Size(190, 20);
            this.mtxtCMND.TabIndex = 3;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(418, 136);
            this.mtxtSoDT.Mask = "0000000000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(184, 20);
            this.mtxtSoDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(115, 172);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(487, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.ColumnWidth = 158;
            this.clbMonHoc.ContextMenuStrip = this.contextMenuMonHoc;
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
            this.clbMonHoc.Location = new System.Drawing.Point(132, 211);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(487, 64);
            this.clbMonHoc.TabIndex = 10;
            // 
            // contextMenuMonHoc
            // 
            this.contextMenuMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemMon,
            this.mnuXoaMon});
            this.contextMenuMonHoc.Name = "contextMenuMonHoc";
            this.contextMenuMonHoc.Size = new System.Drawing.Size(133, 48);
            // 
            // mnuThemMon
            // 
            this.mnuThemMon.Name = "mnuThemMon";
            this.mnuThemMon.Size = new System.Drawing.Size(132, 22);
            this.mnuThemMon.Text = "Thêm môn";
            this.mnuThemMon.Click += new System.EventHandler(this.mnuThemMon_Click);
            // 
            // mnuXoaMon
            // 
            this.mnuXoaMon.Name = "mnuXoaMon";
            this.mnuXoaMon.Size = new System.Drawing.Size(132, 22);
            this.mnuXoaMon.Text = "Xóa môn";
            this.mnuXoaMon.Click += new System.EventHandler(this.mnuXoaMon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(227, 289);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 29);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(324, 289);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(80, 29);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(421, 289);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 29);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(518, 289);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Môn học đăng ký:";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoLot,
            this.colTen,
            this.colNgaySinh,
            this.colLop,
            this.colCMND,
            this.colSoDT,
            this.colDiaChi});
            this.lvSinhVien.ContextMenuStrip = this.contextMenuSinhVien;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(28, 352);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(574, 214);
            this.lvSinhVien.TabIndex = 15;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 65;
            // 
            // colHoLot
            // 
            this.colHoLot.Text = "Họ và tên lót";
            this.colHoLot.Width = 105;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.Width = 65;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 80;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 55;
            // 
            // colCMND
            // 
            this.colCMND.Text = "Số CMND";
            this.colCMND.Width = 85;
            // 
            // colSoDT
            // 
            this.colSoDT.Text = "Số điện thoại";
            this.colSoDT.Width = 90;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ liên lạc";
            this.colDiaChi.Width = 120;
            // 
            // contextMenuSinhVien
            // 
            this.contextMenuSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoaSinhVien});
            this.contextMenuSinhVien.Name = "contextMenuSinhVien";
            this.contextMenuSinhVien.Size = new System.Drawing.Size(145, 26);
            // 
            // mnuXoaSinhVien
            // 
            this.mnuXoaSinhVien.Name = "mnuXoaSinhVien";
            this.mnuXoaSinhVien.Size = new System.Drawing.Size(144, 22);
            this.mnuXoaSinhVien.Text = "Xóa sinh viên";
            this.mnuXoaSinhVien.Click += new System.EventHandler(this.mnuXoaSinhVien_Click);
            // 
            // cboDinhDang
            // 
            this.cboDinhDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDinhDang.FormattingEnabled = true;
            this.cboDinhDang.Items.AddRange(new object[] {
            "TXT",
            "",
            "JSON",
            "",
            "XML"});
            this.cboDinhDang.Location = new System.Drawing.Point(19, 294);
            this.cboDinhDang.Name = "cboDinhDang";
            this.cboDinhDang.Size = new System.Drawing.Size(121, 21);
            this.cboDinhDang.TabIndex = 20;
            // 
            // btnTaiDuLieu
            // 
            this.btnTaiDuLieu.Location = new System.Drawing.Point(146, 292);
            this.btnTaiDuLieu.Name = "btnTaiDuLieu";
            this.btnTaiDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnTaiDuLieu.TabIndex = 21;
            this.btnTaiDuLieu.Text = "Tải dữ liệu";
            this.btnTaiDuLieu.UseVisualStyleBackColor = true;
            this.btnTaiDuLieu.Click += new System.EventHandler(this.btnTaiDuLieu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 589);
            this.Controls.Add(this.btnTaiDuLieu);
            this.Controls.Add(this.cboDinhDang);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.mtxtCMND);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.mtxtMSSV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuMonHoc.ResumeLayout(false);
            this.contextMenuSinhVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.MaskedTextBox mtxtCMND;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoLot;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colCMND;
        private System.Windows.Forms.ColumnHeader colSoDT;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ContextMenuStrip contextMenuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuThemMon;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaMon;
        private System.Windows.Forms.ContextMenuStrip contextMenuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaSinhVien;
        private System.Windows.Forms.ComboBox cboDinhDang;
        private System.Windows.Forms.Button btnTaiDuLieu;
    }
}