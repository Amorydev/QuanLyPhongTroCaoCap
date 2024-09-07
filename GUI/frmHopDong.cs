using BLL;
using DTO;
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
    public partial class frmHopDong : Form
    {
        HopDongBLL hopDongBLL = new HopDongBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        PhongBLL phongBLL = new PhongBLL();
        HopDongDTO hopDongDTO = new HopDongDTO();
        bool isAdd = false;
        public frmHopDong()
        {
            InitializeComponent();
            dgvHopDong.DataSource = hopDongBLL.GetDataHopDong();
            layDuLieuKhachHang();
            layDuLieuPhong();
            nUDGiaPhong.Maximum = 1000000000;
            nUDTienDatCoc.Maximum = 1000000000;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            layDuLieuKhachHang();
            layDuLieuPhong();
            dgvHopDong.DataSource = hopDongBLL.GetDataHopDong();
        }

        private void layDuLieuKhachHang()
        {
            DataTable dataTable = khachHangBLL.GetDataKhachHang();

            cbMaKhachHang.DisplayMember = "MaKhachHang";
            cbMaKhachHang.ValueMember = "MaKhachHang";
            cbMaKhachHang.DataSource = dataTable;
        }

        private void layDuLieuPhong()
        {
            DataTable dataTable = phongBLL.GetDataPhong();

            cbMaPhong.DisplayMember = "MaPhong";
            cbMaPhong.ValueMember = "MaPhong";

            cbMaPhong.DataSource = dataTable;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMaHopDong.Clear();
            nUDTienDatCoc.Value = 0;
            nUDGiaPhong.Value = 0;
            dtNgayThue.Value = DateTime.Now;
            dtNgayTraPhong.Value = DateTime.Now;
            btnXoa.Enabled = false;
        }
        private void layDuLieuHopDong()
        {
            hopDongDTO.MaHopDong = txtMaHopDong.Text;
            hopDongDTO.MaKhachHang = cbMaKhachHang.SelectedValue.ToString();
            hopDongDTO.MaPhong = cbMaPhong.SelectedValue.ToString();
            hopDongDTO.GiaPhong = (float)nUDGiaPhong.Value;
            hopDongDTO.TienDatCoc = (float)nUDTienDatCoc.Value;
            hopDongDTO.NgayThue = dtNgayThue.Value;
            hopDongDTO.NgayTraPhong = dtNgayTraPhong.Value;
        }


        private void cbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = khachHangBLL.GetDataKhachHang();
            if (cbMaKhachHang.SelectedValue != null)
            {
                string selectedMaKhachHang = cbMaKhachHang.SelectedValue.ToString();

                DataRow[] rows = dataTable.Select("MaKhachHang = '" + selectedMaKhachHang + "'");

                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    string hoTen = row["HoTen"].ToString();
                    string cccd = row["CCCD"].ToString();
                    string dienThoai = row["DienThoai"].ToString();

                    txtHoTen.Text = hoTen;
                    txtHoTen.Enabled = false;
                    txtCMND.Text = cccd;
                    txtCMND.Enabled = false;
                    txtSDT.Text = dienThoai;
                    txtSDT.Enabled = false;
                }
            }
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = phongBLL.GetDataPhong();
            if (cbMaPhong.SelectedValue != null)
            {
                string selectedPhong = cbMaPhong.SelectedValue.ToString();

                DataRow[] rows = dataTable.Select("MaPhong = '" + selectedPhong + "'");

                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    string tenPhong = row["TenPhong"].ToString();
                    txtTenPhong.Text = tenPhong;
                    txtTenPhong.Enabled = false;

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            layDuLieuHopDong();
            if (isAdd)
            {
                if (hopDongBLL.CheckSave(hopDongDTO))
                {
                    hopDongBLL.addHopDong(hopDongDTO);
                    isAdd = false;
                    btnXoa.Enabled = true;
                }
            }
            frmHopDong_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layDuLieuHopDong();  
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hopDongBLL.DeleteHopDong(hopDongDTO);                   
                    frmHopDong_Load(sender, e);
            }
           
        }
        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHopDong.DataBindings.Clear();
            txtMaHopDong.DataBindings.Add("Text", dgvHopDong.DataSource, "MaHopDong");
            nUDTienDatCoc.DataBindings.Clear();
            nUDTienDatCoc.DataBindings.Add("Text", dgvHopDong.DataSource, "TienDatCoc");
            nUDGiaPhong.DataBindings.Clear();
            nUDGiaPhong.DataBindings.Add("Text", dgvHopDong.DataSource, "GiaPhong");
            cbMaKhachHang.DataBindings.Clear();
            cbMaKhachHang.DataBindings.Add("Text", dgvHopDong.DataSource, "MaKhachHang");
            cbMaPhong.DataBindings.Clear();
            cbMaPhong.DataBindings.Add("Text", dgvHopDong.DataSource, "MaPhong");
            dtNgayThue.DataBindings.Clear();
            dtNgayThue.DataBindings.Add("Text", dgvHopDong.DataSource, "NgayThue");
            dtNgayTraPhong.DataBindings.Clear();
            dtNgayTraPhong.DataBindings.Add("Text", dgvHopDong.DataSource, "NgayTraPhong");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
            frmManHinhChinh.ShowDialog();
            this.Close();
        }
    }
}
