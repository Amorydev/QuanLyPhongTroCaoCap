using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        NguoiDungBLL ndBLL = new NguoiDungBLL();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhauMoi = txtNhapLaiMatKhauMoi.Text;

            if (string.IsNullOrEmpty(taiKhoan))
            {
                MessageBox.Show("Vui lòng nhập tài khoản.");
                return;
            }

            if (string.IsNullOrEmpty(matKhauCu))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ.");
                return;
            }

            if (string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.");
                return;
            }

            if (string.IsNullOrEmpty(nhapLaiMatKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới.");
                return;
            }

            if (matKhauMoi != nhapLaiMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không khớp.");
                return;
            }
            //bool doiMatKhauThanhCong = ndBLL.ChangePassword(taiKhoan, matKhauCu, matKhauMoi);

            if (ndBLL.ChangePassword(taiKhoan, matKhauCu, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng hoặc có lỗi xảy ra!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Session.CurrentUser;
            txtTaiKhoan.Enabled = false;
        }
    }
}
