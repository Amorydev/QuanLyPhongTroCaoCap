using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
            lblXinChao.Text += BLL.Session.CurrentUser;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblXinChao_Click(object sender, EventArgs e)
        {

        }

        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                BLL.Session.CurrentUser = null;
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            frmPhong.Show();
            this.Close();
        }

        private void quảnLýPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            frmPhong.Show();
            this.Close();
        }
    }
}
