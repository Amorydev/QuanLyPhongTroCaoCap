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
    public partial class frmThietBi : Form
    {
        public frmThietBi()
        {
            InitializeComponent();
        }

        TangDTO tangDTO = new TangDTO();
        TangBLL tangBLL = new TangBLL();
        ThietBiDTO thietBiDTO = new ThietBiDTO();
        ThietBiBLL thietBiBLL = new ThietBiBLL();
        bool addTang = false;
        bool addThietBi = false;


        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            
            List<TangDTO> dsTang = tangBLL.GetDataTang();

            cboChonTang.DisplayMember = "TenTang";
            cboChonTang.ValueMember = "MaTang";

            cboChonTang.DataSource = dsTang;

            txtMaTang.DataBindings.Clear();
            txtMaTang.DataBindings.Add("Text", cboChonTang.DataSource, "MaTang");
            txtTenTang.DataBindings.Clear();
            txtTenTang.DataBindings.Add("Text", cboChonTang.DataSource, "TenTang");

            txtTenTang.Enabled = false;
            txtMaTang.Enabled = false;
        }
        private void layDuLieuTang()
        {
           tangDTO.MaTang = txtMaTang.Text;
           tangDTO.TenTang = txtTenTang.Text;
        }

        private void layDuLieuThietBi()
        {
            thietBiDTO.MaThietBi = txtMaTB.Text;
            thietBiDTO.TenThietBi = txtTenTB.Text;
            thietBiDTO.SoLuong = int.Parse(nudSoLuongTB.Text);
            thietBiDTO.NgayMua = dtpNgayMuaTB.Value;
            thietBiDTO.NgayBaoDuong = dtpNgayBDTB.Value;
            thietBiDTO.TrangThai = txtTrangThaiTB.Text;
            thietBiDTO.TienMua = int.Parse(nudTienMuaTB.Text);
            thietBiDTO.TienBaoDuong = int.Parse(nudTienBDTB.Text);
            thietBiDTO.MaTang = cboChonTang.SelectedValue.ToString();
        }
        private void cboChonTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = thietBiBLL.GetDataThietBiByTang(cboChonTang.SelectedValue.ToString());
            dgvThietBi.DataSource = dt;

            txtMaTB.DataBindings.Clear();
            txtMaTB.DataBindings.Add("Text", dgvThietBi.DataSource, "MaThietBi");
            txtTenTB.DataBindings.Clear();
            txtTenTB.DataBindings.Add("Text", dgvThietBi.DataSource, "TenThietBi");
            nudSoLuongTB.DataBindings.Clear();
            nudSoLuongTB.DataBindings.Add("Text", dgvThietBi.DataSource, "SoLuong");
            dtpNgayMuaTB.DataBindings.Clear();
            dtpNgayMuaTB.DataBindings.Add("Text", dgvThietBi.DataSource, "NgayMua");
            dtpNgayBDTB.DataBindings.Clear();
            dtpNgayBDTB.DataBindings.Add("Text", dgvThietBi.DataSource, "NgayBaoDuong");
            txtTrangThaiTB.DataBindings.Clear();
            txtTrangThaiTB.DataBindings.Add("Text", dgvThietBi.DataSource, "TrangThai");
            nudTienMuaTB.DataBindings.Clear();
            nudTienMuaTB.DataBindings.Add("Text", dgvThietBi.DataSource, "TienMua");
            nudTienBDTB.DataBindings.Clear();
            nudTienBDTB.DataBindings.Add("Text", dgvThietBi.DataSource, "TienBaoDuong");
        }

        //xu ly phan tang
        private void btnThemTang_Click(object sender, EventArgs e)
        {
            txtTenTang.Enabled = true;
            txtMaTang.Enabled = true;
            txtTenTang.Clear();
            txtMaTang.Clear();
            txtMaTang.Focus();
            addTang = true;
            btnSuaTang.Enabled = false;
            btnXoaTang.Enabled = false;

        }

        private void btnSuaTang_Click(object sender, EventArgs e)
        {
            txtTenTang.Enabled = true;
            txtTenTang.Focus();
            btnThemTang.Enabled = false;
            btnXoaTang.Enabled = false;

        }

        private void btnLuuTang_Click(object sender, EventArgs e)
        {
            layDuLieuTang();
            if (addTang == true)
            {
                if (tangBLL.CheckSave(tangDTO))
                {
                    tangBLL.AddTang(tangDTO);
                    
                }
                addTang = false;
                btnSuaTang.Enabled = true;
                btnXoaTang.Enabled = true;
                frmThietBi_Load(sender, e);
            }
            else
            {
                tangBLL.UpdateTang(tangDTO);
                btnThemTang.Enabled = true;
                btnXoaTang.Enabled = true;
            }
        }

        private void btnXoaTang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tangBLL.DeleteTang(txtMaTang.Text);
                frmThietBi_Load(sender, e);
            }
        }

        // xu ly phan thiet bi
        private void btnThemTB_Click(object sender, EventArgs e)
        {
            txtMaTB.Clear();
            txtTenTB.Clear();
            nudSoLuongTB.Value = 0;
            dtpNgayMuaTB.Value = DateTime.Now;
            dtpNgayBDTB.Value = DateTime.Now;
            txtTrangThaiTB.Clear();
            nudTienMuaTB.Value = 0;
            nudTienBDTB.Value = 0;
            txtMaTB.Focus();
            addThietBi = true;
            btnSuaTB.Enabled = false;
            btnXoaTB.Enabled = false;

        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            txtMaTB.Enabled = false;
            txtTenTB.Focus();
            btnThemTB.Enabled = false;
            btnXoaTB.Enabled = false;
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thietBiBLL.DeleteThietBi(txtMaTB.Text);
                cboChonTang_SelectedIndexChanged(sender, e);
            }
        }

        private void btnLuuTB_Click(object sender, EventArgs e)
        {
            if (addThietBi == true)
            {
                layDuLieuThietBi();
                if (thietBiBLL.CheckSave(thietBiDTO))
                {
                    thietBiBLL.AddThietBi(thietBiDTO);
                   
                }
                addThietBi = false;
                btnSuaTB.Enabled = true;
                btnXoaTB.Enabled = true;
                cboChonTang_SelectedIndexChanged(sender, e);
            }
            else
            {
                layDuLieuThietBi();
                thietBiBLL.UpdateThietBi(thietBiDTO);
                btnThemTB.Enabled = true;
                btnXoaTB.Enabled = true;
                txtMaTB.Enabled = true;
                cboChonTang_SelectedIndexChanged(sender, e);
            }
        }

    }
}
