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
    public partial class frmKhachHang : Form
    {
        KhachHangDTO kh = new KhachHangDTO();
        KhachHangBLL khbll = new KhachHangBLL();
        private bool addKH = false;


        private void LayDLKhachHang()
        {
            kh.MaKhachHang = txtMaKH.Text;
            kh.HoTen = txtHoTenKH.Text;
            kh.CCCD = txtCCCD.Text;
            kh.NgaySinh = dtpNgaySinh.Value;
            kh.GioiTinh = txtGioiTinh.Text;
            kh.DienThoai = txtDienThoai.Text;
            kh.QueQuan = txtQueQuan.Text;
            kh.NgheNghiep = txtNgheNghiep.Text;

        }

        public frmKhachHang()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay lại trang chủ không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = khbll.GetDataKhachHang();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKH.DataSource, "MaKhachHang");
            txtHoTenKH.DataBindings.Clear();
            txtHoTenKH.DataBindings.Add("Text", dgvKH.DataSource, "HoTen");
            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", dgvKH.DataSource, "CCCD");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvKH.DataSource, "NgaySinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvKH.DataSource, "GioiTinh");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvKH.DataSource, "DienThoai");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", dgvKH.DataSource, "QueQuan");
            txtNgheNghiep.DataBindings.Clear();
            txtNgheNghiep.DataBindings.Add("Text", dgvKH.DataSource, "NgheNghiep");

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTenKH.Clear();
            txtCCCD.Clear();
            txtGioiTinh.Clear();
            txtDienThoai.Clear();
            txtQueQuan.Clear();
            txtNgheNghiep.Clear();
            txtMaKH.Focus();

            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;

            addKH = true;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtHoTenKH.Focus();

            btnThemKH.Enabled = false;
            btnXoaKH.Enabled = false;

        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            LayDLKhachHang();
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                khbll.DeleteKhachHang(kh.MaKhachHang);
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            LayDLKhachHang();
            if (addKH)
            {
                if (khbll.CheckSave(kh))
                {
                    khbll.AddKhachHang(kh);
                   
                }
                btnSuaKH.Enabled = true;
                btnXoaKH.Enabled = true;
                addKH = false;
                
            }
            else
            {
                khbll.UpdateKhachHang(kh);
                btnThemKH.Enabled = true;
                btnXoaKH.Enabled = true;
                txtMaKH.Enabled = true;
            }
            
            frmKhachHang_Load(sender, e);
        }
    }
}
