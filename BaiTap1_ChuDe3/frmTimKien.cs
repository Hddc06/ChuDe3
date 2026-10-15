using System;
using System.Windows.Forms;

namespace BaiTap1_ChuDe3
{
    public partial class frmTimKiem : Form
    {
        public string KieuTim { get; set; }
        public string NoiDungTim { get; set; }

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            this.rdMSSV.Checked = true;
            this.txtNoiDung.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.txtNoiDung.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập thông tin cần tìm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.txtNoiDung.Focus();
                return;
            }

            if (this.rdMSSV.Checked)
            {
                this.KieuTim = "MSSV";
            }
            else if (this.rdTen.Checked)
            {
                this.KieuTim = "Ten";
            }
            else
            {
                this.KieuTim = "Lop";
            }

            this.NoiDungTim = this.txtNoiDung.Text.Trim();

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}