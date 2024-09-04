using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI

{
    public partial class frmDangNhap : Form
    {
        NguoiDungDTO nguoidung = new NguoiDungDTO();
        NguoiDungBLL ndBLL = new NguoiDungBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nguoidung.TaiKhoan = txtTaiKhoan.Text;
            nguoidung.MatKhau = txtMatKhau.Text;

            string user = ndBLL.Login(nguoidung);
            
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BLL.Session.CurrentUser = user;
                this.Hide();
                frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
                frmManHinhChinh.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            BLL.Session.CurrentUser = null;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
