using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BaiTap1_ChuDe3
{
    public partial class frmMain : Form
    {
        QLSinhVien qlsv = new QLSinhVien();

        public frmMain()
        {
            InitializeComponent();
        }

        private void ThemSVLenListView(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MSSV);

            item.SubItems.Add(sv.HoLot);
            item.SubItems.Add(sv.Ten);
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.CMND);
            item.SubItems.Add(sv.SoDT);
            item.SubItems.Add(sv.DiaChi);

            item.Tag = sv;

            this.lvSinhVien.Items.Add(item);
        }

        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();

            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSVLenListView(sv);
            }
        }

        private void LoadDanhSachLop()
        {
            this.cboLop.Items.Clear();

            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                if (!this.cboLop.Items.Contains(sv.Lop))
                {
                    this.cboLop.Items.Add(sv.Lop);
                }
            }

            if (this.cboLop.Items.Count > 0)
            {
                this.cboLop.SelectedIndex = 0;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // qlsv.DocTuFile();
            //qlsv.DocFileJSON();
            this.cboDinhDang.SelectedIndex = 0;



            LoadListView();

            LoadDanhSachLop();

            this.rdNam.Checked = true;
        }
        private void HienThiSinhVien(SinhVien sv)
        {
            if (sv == null)
                return;

            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoLot.Text = sv.HoLot;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;

            if (sv.GioiTinh)
            {
                this.rdNam.Checked = true;
            }
            else
            {
                this.rdNu.Checked = true;
            }

            this.cboLop.Text = sv.Lop;
            this.mtxtCMND.Text = sv.CMND;
            this.mtxtSoDT.Text = sv.SoDT;
            this.txtDiaChi.Text = sv.DiaChi;

            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
            {
                this.clbMonHoc.SetItemChecked(i, false);
            }

            foreach (string mon in sv.MonHoc)
            {
                for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                {
                    if (this.clbMonHoc.Items[i].ToString() == mon)
                    {
                        this.clbMonHoc.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvSinhVien.SelectedItems[0];

                SinhVien sv = item.Tag as SinhVien;

                HienThiSinhVien(sv);

                this.mtxtMSSV.ReadOnly = true;
            }
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();

            sv.MSSV = this.mtxtMSSV.Text.Trim();
            sv.HoLot = this.txtHoLot.Text.Trim();
            sv.Ten = this.txtTen.Text.Trim();
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.GioiTinh = this.rdNam.Checked;
            sv.Lop = this.cboLop.Text;
            sv.CMND = this.mtxtCMND.Text.Trim();
            sv.SoDT = this.mtxtSoDT.Text.Trim();
            sv.DiaChi = this.txtDiaChi.Text.Trim();

            foreach (object item in this.clbMonHoc.CheckedItems)
            {
                sv.MonHoc.Add(item.ToString());
            }

            return sv;
        }

        private bool KiemTraDuLieu()
        {
            if (!this.mtxtMSSV.MaskCompleted)
            {
                MessageBox.Show(
                    "MSSV phải gồm 7 chữ số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.mtxtMSSV.Focus();
                return false;
            }

            if (this.txtHoLot.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên lót!");
                this.txtHoLot.Focus();
                return false;
            }

            if (this.txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên!");
                this.txtTen.Focus();
                return false;
            }

            if (!this.rdNam.Checked && !this.rdNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            if (this.cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return false;
            }

            if (!this.mtxtCMND.MaskCompleted)
            {
                MessageBox.Show("CMND phải gồm 9 chữ số!");
                this.mtxtCMND.Focus();
                return false;
            }

            if (!this.mtxtSoDT.MaskCompleted)
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số!");
                this.mtxtSoDT.Focus();
                return false;
            }

            if (this.txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                this.txtDiaChi.Focus();
                return false;
            }

            if (this.clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn học!");
                return false;
            }

            return true;
        }
        private void XoaThongTinNhap()
        {
            this.mtxtMSSV.Text = "";
            this.txtHoLot.Text = "";
            this.txtTen.Text = "";

            this.dtpNgaySinh.Value = DateTime.Now;

            this.rdNam.Checked = true;
            this.rdNu.Checked = false;

            this.mtxtCMND.Text = "";
            this.mtxtSoDT.Text = "";
            this.txtDiaChi.Text = "";

            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
            {
                this.clbMonHoc.SetItemChecked(i, false);
            }

            this.mtxtMSSV.Focus();
            this.mtxtMSSV.ReadOnly = false;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            SinhVien sv = GetSinhVien();

            SinhVien tim = qlsv.TimTheoMSSV(sv.MSSV);

            if (tim != null)
            {
                MessageBox.Show(
                    "MSSV này đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.mtxtMSSV.Focus();
                return;
            }

            qlsv.Them(sv);

            LoadListView();

            MessageBox.Show(
                "Thêm sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            XoaThongTinNhap();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                System.Collections.Generic.List<SinhVien> ketQua =
                    new System.Collections.Generic.List<SinhVien>();

                if (frm.KieuTim == "MSSV")
                {
                    SinhVien sv =
                        qlsv.TimTheoMSSV(frm.NoiDungTim);

                    if (sv != null)
                    {
                        ketQua.Add(sv);
                    }
                }
                else if (frm.KieuTim == "Ten")
                {
                    ketQua =
                        qlsv.TimTheoTen(frm.NoiDungTim);
                }
                else
                {
                    ketQua =
                        qlsv.TimTheoLop(frm.NoiDungTim);
                }

                HienThiDanhSachTimKiem(ketQua);

                MessageBox.Show(
                    "Tìm thấy " + ketQua.Count + " sinh viên.",
                    "Kết quả tìm kiếm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                LoadListView();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            SinhVien sv = GetSinhVien();

            SinhVien tim = qlsv.TimTheoMSSV(sv.MSSV);

            if (tim == null)
            {
                MessageBox.Show(
                    "Không tìm thấy sinh viên cần cập nhật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            qlsv.CapNhat(sv);

            LoadListView();

            MessageBox.Show(
                "Cập nhật sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            XoaThongTinNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void HienThiDanhSachTimKiem(
    System.Collections.Generic.List<SinhVien> danhSach)
        {
            this.lvSinhVien.Items.Clear();

            foreach (SinhVien sv in danhSach)
            {
                ThemSVLenListView(sv);
            }
        }
        private void mnuXoaSinhVien_Click(object sender, EventArgs e)
        {
            if (this.lvSinhVien.CheckedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng đánh dấu sinh viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa các sinh viên đã chọn không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                return;

            System.Collections.Generic.List<string> dsMa =
                new System.Collections.Generic.List<string>();

            foreach (ListViewItem item in this.lvSinhVien.CheckedItems)
            {
                dsMa.Add(item.SubItems[0].Text);
            }

            foreach (string ma in dsMa)
            {
                qlsv.Xoa(ma);
            }

            LoadListView();

            XoaThongTinNhap();

            MessageBox.Show(
                "Xóa sinh viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private string NhapTenMon()
        {
            Form frm = new Form();
            Label lbl = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnHuy = new Button();

            frm.Text = "Thêm môn học";
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.ClientSize = new System.Drawing.Size(330, 125);

            lbl.Text = "Tên môn:";
            lbl.Location = new System.Drawing.Point(18, 22);
            lbl.AutoSize = true;

            txt.Location = new System.Drawing.Point(80, 19);
            txt.Size = new System.Drawing.Size(225, 20);

            btnOK.Text = "Thêm";
            btnOK.Location = new System.Drawing.Point(80, 65);
            btnOK.Size = new System.Drawing.Size(90, 28);
            btnOK.DialogResult = DialogResult.OK;

            btnHuy.Text = "Hủy";
            btnHuy.Location = new System.Drawing.Point(185, 65);
            btnHuy.Size = new System.Drawing.Size(90, 28);
            btnHuy.DialogResult = DialogResult.Cancel;

            frm.Controls.Add(lbl);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnHuy);

            frm.AcceptButton = btnOK;
            frm.CancelButton = btnHuy;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                return txt.Text.Trim();
            }

            return "";
        }


        private void mnuXoaMon_Click(object sender, EventArgs e)
        {
            if (this.clbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn môn học cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string mon =
                this.clbMonHoc.SelectedItem.ToString();

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa môn \"" +
                mon + "\" không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                this.clbMonHoc.Items.RemoveAt(
                    this.clbMonHoc.SelectedIndex);
            }
        }

        private void mnuThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên môn học:",
                "Thêm môn học",
                "");

            if (tenMon.Trim() == "")
                return;

            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
            {
                if (this.clbMonHoc.Items[i].ToString()
                    .Equals(tenMon.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Môn học này đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            this.clbMonHoc.Items.Add(tenMon.Trim());

            MessageBox.Show(
                "Thêm môn học thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            if (this.cboDinhDang.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn định dạng tập tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string dinhDang = this.cboDinhDang.Text;

            if (dinhDang == "TXT")
            {
                qlsv.DocTuFile();
            }
            else if (dinhDang == "JSON")
            {
                qlsv.DocFileJSON();
            }
            else if (dinhDang == "XML")
            {
                if (!qlsv.DocFileXML())
                    return;
            }

            LoadListView();
            LoadDanhSachLop();

            LoadListView();
            LoadDanhSachLop();

            MessageBox.Show(
                "Tải dữ liệu " + dinhDang +
                " thành công!\nSố sinh viên: " +
                qlsv.dsSinhVien.Count,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LuuDuLieu()
        {
            string dinhDang = this.cboDinhDang.Text;

            if (dinhDang == "TXT")
            {
                qlsv.GhiVaoFile();
            }
            else if (dinhDang == "JSON")
            {
                qlsv.GhiFileJSON();
            }
            else if (dinhDang == "XML")
            {
                qlsv.GhiFileXML();
            }
        }
    }
}