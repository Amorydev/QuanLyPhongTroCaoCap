﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmPhong : Form
    {
        private readonly PhongBLL phongBLL = new PhongBLL();
        private bool isAddPhong = false;
        private PhongDTO phongDTO = new PhongDTO();

        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += pictureBox1_Paint;
            
            layDuLieuTang();
            dgvPhong.SelectionChanged += new EventHandler(dgvPhong_SelectionChanged);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle click event if needed
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(pictureBox1.Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(pictureBox1.Width - radius, pictureBox1.Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, pictureBox1.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void layDuLieuPhong()
        {
            phongDTO.TenPhong = txtTenPhong.Text;
            phongDTO.MaPhong = txtMaPhong.Text;
            phongDTO.LoaiPhong = txtLoaiPhong.Text;
            if (float.TryParse(txtGiaPhong.Text, out float giaPhong))
            {
                phongDTO.GiaPhong = giaPhong;
            }
            else
            {
                MessageBox.Show("Giá phòng không hợp lệ, vui lòng nhập lại.");
                return; // Dừng lại nếu giá phòng không hợp lệ
            }

            phongDTO.NoiThat = txtNoiThat.Text;
            phongDTO.MaTang = cbMaTang.SelectedValue.ToString();

            phongDTO.TrangThai = rbDaChoThue.Checked ? "Đã cho thuê" : "Còn trống";
        }

        private void layDuLieuTang()
        {
            TangBLL tangBLL = new TangBLL();
            List<TangDTO> tangList = tangBLL.GetMaTang();

            cbMaTang.DisplayMember = "TenTang";
            cbMaTang.ValueMember = "MaTang";

            cbMaTang.DataSource = tangList;

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtLoaiPhong.Clear();
            txtNoiThat.Clear();
            txtGiaPhong.Clear();
            txtMaPhong.Focus();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            
            isAddPhong = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            layDuLieuPhong();

            if (isAddPhong)
            {
                if (phongBLL.CheckSave(phongDTO))
                {
                    phongBLL.AddPhong(phongDTO);
                    isAddPhong = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(phongDTO.MaPhong))
                {
                    phongBLL.UpdatePhong(phongDTO);
                    
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    txtMaPhong.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã phòng không hợp lệ.");
                }
            }

            frmPhong_Load(sender, e); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
            txtMaPhong.Enabled = false;
            txtTenPhong.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            layDuLieuPhong();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                phongBLL.DeletePhongban(phongDTO);
                frmPhong_Load(sender, e); 
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay lại trang chủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
                frmManHinhChinh.ShowDialog();
            }
        }

        private void cbMaTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaTang.SelectedValue != null)
            {
                dgvPhong.DataSource = phongBLL.GetDataPhongByTang(cbMaTang.SelectedValue.ToString());

                // Thiết lập lại DataBindings
                txtMaPhong.DataBindings.Clear();
                txtMaPhong.DataBindings.Add("Text", dgvPhong.DataSource, "MaPhong");
                txtTenPhong.DataBindings.Clear();
                txtTenPhong.DataBindings.Add("Text", dgvPhong.DataSource, "TenPhong");
                txtLoaiPhong.DataBindings.Clear();
                txtLoaiPhong.DataBindings.Add("Text", dgvPhong.DataSource, "LoaiPhong");
                txtGiaPhong.DataBindings.Clear();
                txtGiaPhong.DataBindings.Add("Text", dgvPhong.DataSource, "GiaPhong");
                txtNoiThat.DataBindings.Clear();
                txtNoiThat.DataBindings.Add("Text", dgvPhong.DataSource, "NoiThat");

                // Gọi phương thức để cập nhật trạng thái RadioButton cho dòng đầu tiên
                dgvPhong_SelectionChanged(sender, e);

            }
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow != null && dgvPhong.CurrentRow.Cells["TrangThai"].Value != null)
            {
                string trangThai = dgvPhong.CurrentRow.Cells["TrangThai"].Value.ToString();

                // Cập nhật trạng thái các RadioButton dựa trên giá trị của "TrangThai"
                rbDaChoThue.Checked = trangThai == "Đã cho thuê";
                rbConTrong.Checked = trangThai == "Còn trống";
            }
        }
    }
}
