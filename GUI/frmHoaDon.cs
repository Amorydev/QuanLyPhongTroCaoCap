using BLL;
using DTO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Reflection;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        HoaDonDTO hoaDonDTO = new HoaDonDTO();
        PhongBLL phongBLL = new PhongBLL();
        bool isAddHoaDon = false;

        public frmHoaDon()
        {
            InitializeComponent();
            dtgvHoaDon.DataSource = hoaDonBLL.GetDataHoaDon();
            layDuLieuPhong();
            dtTuNgay.ValueChanged += dtTuNgay_ValueChanged;
        }

        private void dtgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dtgvHoaDon.DataSource = hoaDonBLL.GetDataHoaDon();
            layDuLieuPhong();
        }

        private void layDuLieuPhong()
        {
            DataTable dataTable = phongBLL.GetDataPhong();
            cbMaPhong.DisplayMember = "MaPhong";
            cbMaPhong.ValueMember = "MaPhong";
            cbMaPhong.DataSource = dataTable;
        }
        private void layDuLieuHoaDon()
        {
            hoaDonDTO.MaHoaDon = txtMaHoaDon.Text;
            hoaDonDTO.MaPhong = cbMaPhong.SelectedValue.ToString();
            hoaDonDTO.TuNgay = dtTuNgay.Value;
            hoaDonDTO.ToiNgay = dtDenNgay.Value;
            if (float.TryParse(txtTienPhong.Text, out float giaPhong))
            {
                hoaDonDTO.TienPhong = giaPhong;
            }
            if (float.TryParse(txtTienDien.Text, out float tiendien))
            {
                hoaDonDTO.TienDien = giaPhong;
            }
            if (float.TryParse(txtTienNuoc.Text, out float tiennuoc))
            {
                hoaDonDTO.TienNuoc = giaPhong;
            }
            if (float.TryParse(txtTienDichVu.Text, out float tiendichvu))
            {
                hoaDonDTO.TienDichVu = giaPhong;
            }

            hoaDonDTO.TongTien = tinhTien();
            
        }

        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            dtTuNgay.ValueChanged -= dtTuNgay_ValueChanged;
            try
            {
                DateTime dt1Date = dtTuNgay.Value;
                DateTime newDateForDt2 = dt1Date.AddMonths(1);
                dtDenNgay.Value = newDateForDt2;
            }
            finally
            {
                dtTuNgay.ValueChanged += dtTuNgay_ValueChanged;
            }
        }

        

        private string formatTien(string numberString)
        {
            if (string.IsNullOrWhiteSpace(numberString))
            {
                return "Invalid number";
            }
            if (float.TryParse(numberString, NumberStyles.Any, CultureInfo.InvariantCulture, out float number))
            {
                NumberFormatInfo numberFormat = new NumberFormatInfo
                {
                    NumberGroupSeparator = ".",
                    NumberDecimalSeparator = ","
                };
                return number.ToString("N0", numberFormat);
            }
            else
            {
                return "Invalid number";
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = tinhTien().ToString();
        }
        private float tinhTien()
{
    float tiendien = 0, tiennuoc = 0, tiendichvu = 0, tienphong = 0;
    CultureInfo culture = CultureInfo.CurrentCulture;

    string tiendienText = txtTienDien.Text.Replace(" ", "").Replace(".", "");
    string tiennuocText = txtTienNuoc.Text.Replace(" ", "").Replace(".", "");
    string tiendichvuText = txtTienDichVu.Text.Replace(" ", "").Replace(".", "");
    string tienphongText = txtTienPhong.Text.Replace(".", "");

    bool validTienDien = !string.IsNullOrWhiteSpace(tiendienText) && float.TryParse(tiendienText, NumberStyles.Float, culture, out tiendien);
    bool validTienNuoc = !string.IsNullOrWhiteSpace(tiennuocText) && float.TryParse(tiennuocText, NumberStyles.Float, culture, out tiennuoc);
    bool validTienDichVu = !string.IsNullOrWhiteSpace(tiendichvuText) && float.TryParse(tiendichvuText, NumberStyles.Float, culture, out tiendichvu);
    bool validTienPhong = !string.IsNullOrWhiteSpace(tienphongText) && float.TryParse(tienphongText, NumberStyles.Float, culture, out tienphong);

    if (validTienDien && validTienNuoc && validTienDichVu && validTienPhong)
    {
        float tongtien = tiendien + tiennuoc + tiendichvu + tienphong;
        return tongtien;
    }
    else
    {
        txtTongTien.Text = "Invalid input";
        MessageBox.Show("Please enter valid numbers for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return 0;  
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
                    string giaPhong = row["GiaPhong"].ToString();
                    txtTienPhong.Text = formatTien(giaPhong);
                    txtTienPhong.Enabled = false;
                }
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
            frmManHinhChinh.ShowDialog();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddHoaDon = true;
            txtMaHoaDon.Clear();
            txtTienDien.Clear();
            txtTienNuoc.Clear();
            txtTienDichVu.Clear();
            dtTuNgay.Value = DateTime.Now;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            layDuLieuHoaDon();
            if (isAddHoaDon)
            {
                if (hoaDonBLL.CheckSave(hoaDonDTO))
                {
                    isAddHoaDon = false;
                    hoaDonBLL.addHoaDon(hoaDonDTO);
                    btnLuu.Enabled = true;
                    txtMaHoaDon.Clear();
                    txtTienDien.Clear();
                    txtTienNuoc.Clear();
                    txtTienDichVu.Clear();
                    txtMaHoaDon.Focus();
                }
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvHoaDon.SelectedRows.Count > 0)
                { 
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add(Missing.Value);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                    for (int i = 0; i < dtgvHoaDon.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dtgvHoaDon.Columns[i].HeaderText;
                    }

                    // Xuất dữ liệu dòng được chọn
                    int rowIndex = 2;  
                    foreach (DataGridViewRow selectedRow in dtgvHoaDon.SelectedRows)
                    {
                        for (int j = 0; j < dtgvHoaDon.Columns.Count; j++)
                        {
                            worksheet.Cells[rowIndex, j + 1] = selectedRow.Cells[j].Value?.ToString();
                        }
                        rowIndex++;
                    }

                    // Định dạng các cột tự động
                    worksheet.Columns.AutoFit();

                    // Lưu file Excel
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        workbook.SaveAs(filePath);
                        workbook.Close(true, Missing.Value, Missing.Value);
                        excelApp.Quit();

                        // Mở file Excel sau khi lưu
                        DialogResult result = MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công! Bạn có muốn xem file không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            Process.Start(filePath);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một dòng để xuất ra Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}