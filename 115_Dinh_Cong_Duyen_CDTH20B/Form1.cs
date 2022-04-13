using System.Text.RegularExpressions;

namespace _115_Dinh_Cong_Duyen_CDTH20B
{
    public partial class Form1 : Form
    {
        Decimal donGia = 0;
        Decimal soLuong = 0;
        Decimal tongSoLong = 0;
        Decimal tongTien = 0;
        int lanBan = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //if (txtSoLuong.Text != "")
            //{
            //    try
            //    {
            //        Decimal a = int.Parse(txtSoLuong.Text.Trim());
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Bạn Không Thể NHập Chử");
            //        txtSoLuong.Clear();
            //        txtSoLuong.Focus();
            //    }
            //}
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            //if (txtDonGia.Text != "")
            //{
            //    try
            //    {
            //        Decimal a = int.Parse(txtSoLuong.Text.Trim());
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Bạn Không Thể NHập Chử");
            //        txtDonGia.Focus();
            //        txtDonGia.Clear();
            //    }
            //}
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                soLuong = int.Parse(txtSoLuong.Text);
                donGia = int.Parse(txtDonGia.Text);
                Decimal thanhTien = soLuong * donGia;
                lblThanhtien2.Text = thanhTien.ToString();
                tongSoLong += soLuong;
                tongTien += thanhTien;
                lanBan++;

                lblTSL.Text = tongSoLong.ToString();
                lblTTien.Text = tongTien.ToString();
                lblTb.Text = (tongTien / lanBan).ToString();
            }
            catch
            {
                MessageBox.Show("bạn Chưa nhập giá trị. vui lòng nhập!");
                txtSoLuong.Focus();
            }
        }

        private void btnBanmoi_Click(object sender, EventArgs e)
        {
            txtSoLuong.Clear();
            txtDonGia.Clear();
            lblThanhtien2.Text = "";
            lblTSL.Text = "";
            lblTTien.Text = "";
            lblTb.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            //{
            //    e.Handled = true;
            //}
            Regex regex = new Regex(@"[^a-zA-Z\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MenuThemBan_Click(object sender, EventArgs e)
        {
            btnBanmoi_Click(sender, e);
        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTinh_Click(sender, e);
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender,e);
        }
    }
}