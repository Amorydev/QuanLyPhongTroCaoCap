namespace GUI
{
    partial class frmBaoCaoKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLPhongTroCaoCapDataSet = new GUI.QLPhongTroCaoCapDataSet();
            this.qLPhongTroCaoCapDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LayDanhSachKhachHangTungPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layDanhSachKhachHangTungPhongTableAdapter = new GUI.QLPhongTroCaoCapDataSetTableAdapters.LayDanhSachKhachHangTungPhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongTroCaoCapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongTroCaoCapDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayDanhSachKhachHangTungPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LayDanhSachKhachHangTungPhongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.rpKhachThuePhong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1374, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLPhongTroCaoCapDataSet
            // 
            this.qLPhongTroCaoCapDataSet.DataSetName = "QLPhongTroCaoCapDataSet";
            this.qLPhongTroCaoCapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLPhongTroCaoCapDataSetBindingSource
            // 
            this.qLPhongTroCaoCapDataSetBindingSource.DataSource = this.qLPhongTroCaoCapDataSet;
            this.qLPhongTroCaoCapDataSetBindingSource.Position = 0;
            // 
            // LayDanhSachKhachHangTungPhongBindingSource
            // 
            this.LayDanhSachKhachHangTungPhongBindingSource.DataMember = "LayDanhSachKhachHangTungPhong";
            this.LayDanhSachKhachHangTungPhongBindingSource.DataSource = this.qLPhongTroCaoCapDataSet;
            // 
            // layDanhSachKhachHangTungPhongTableAdapter
            // 
            this.layDanhSachKhachHangTungPhongTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 575);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaoCaoKhachHang";
            this.Text = "Báo cáo khách thuê";
            this.Load += new System.EventHandler(this.frmBaoCaoKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongTroCaoCapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongTroCaoCapDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayDanhSachKhachHangTungPhongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLPhongTroCaoCapDataSetBindingSource;
        private QLPhongTroCaoCapDataSet qLPhongTroCaoCapDataSet;
        private System.Windows.Forms.BindingSource LayDanhSachKhachHangTungPhongBindingSource;
        private QLPhongTroCaoCapDataSetTableAdapters.LayDanhSachKhachHangTungPhongTableAdapter layDanhSachKhachHangTungPhongTableAdapter;
    }
}