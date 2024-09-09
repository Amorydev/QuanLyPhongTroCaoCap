using Microsoft.Reporting.WinForms;
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
    public partial class frmBaoCaoKhachHang : Form
    {
        public frmBaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.layDanhSachKhachHangTungPhongTableAdapter.Fill(this.qLPhongTroCaoCapDataSet.LayDanhSachKhachHangTungPhong);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi report: " + ex.Message);
            }
            
        }
    }
}
