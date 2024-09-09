namespace GUI
{
    partial class frmThietBi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuTang = new System.Windows.Forms.Button();
            this.btnSuaTang = new System.Windows.Forms.Button();
            this.btnXoaTang = new System.Windows.Forms.Button();
            this.btnThemTang = new System.Windows.Forms.Button();
            this.cboChonTang = new System.Windows.Forms.ComboBox();
            this.txtTenTang = new System.Windows.Forms.TextBox();
            this.txtMaTang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.nudSoLuongTB = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayBDTB = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuaTB = new System.Windows.Forms.DateTimePicker();
            this.txtTrangThaiTB = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTienMuaTB = new System.Windows.Forms.NumericUpDown();
            this.nudTienBDTB = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMuaTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienBDTB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuuTang);
            this.groupBox1.Controls.Add(this.btnSuaTang);
            this.groupBox1.Controls.Add(this.btnXoaTang);
            this.groupBox1.Controls.Add(this.btnThemTang);
            this.groupBox1.Controls.Add(this.cboChonTang);
            this.groupBox1.Controls.Add(this.txtTenTang);
            this.groupBox1.Controls.Add(this.txtMaTang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1305, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tầng";
            // 
            // btnLuuTang
            // 
            this.btnLuuTang.Location = new System.Drawing.Point(715, 70);
            this.btnLuuTang.Name = "btnLuuTang";
            this.btnLuuTang.Size = new System.Drawing.Size(102, 38);
            this.btnLuuTang.TabIndex = 9;
            this.btnLuuTang.Text = "Lưu";
            this.btnLuuTang.UseVisualStyleBackColor = true;
            this.btnLuuTang.Click += new System.EventHandler(this.btnLuuTang_Click);
            // 
            // btnSuaTang
            // 
            this.btnSuaTang.Location = new System.Drawing.Point(540, 70);
            this.btnSuaTang.Name = "btnSuaTang";
            this.btnSuaTang.Size = new System.Drawing.Size(102, 38);
            this.btnSuaTang.TabIndex = 8;
            this.btnSuaTang.Text = "Sửa";
            this.btnSuaTang.UseVisualStyleBackColor = true;
            this.btnSuaTang.Click += new System.EventHandler(this.btnSuaTang_Click);
            // 
            // btnXoaTang
            // 
            this.btnXoaTang.Location = new System.Drawing.Point(889, 70);
            this.btnXoaTang.Name = "btnXoaTang";
            this.btnXoaTang.Size = new System.Drawing.Size(102, 38);
            this.btnXoaTang.TabIndex = 7;
            this.btnXoaTang.Text = "Xóa";
            this.btnXoaTang.UseVisualStyleBackColor = true;
            this.btnXoaTang.Click += new System.EventHandler(this.btnXoaTang_Click);
            // 
            // btnThemTang
            // 
            this.btnThemTang.Location = new System.Drawing.Point(354, 70);
            this.btnThemTang.Name = "btnThemTang";
            this.btnThemTang.Size = new System.Drawing.Size(102, 38);
            this.btnThemTang.TabIndex = 6;
            this.btnThemTang.Text = "Thêm";
            this.btnThemTang.UseVisualStyleBackColor = true;
            this.btnThemTang.Click += new System.EventHandler(this.btnThemTang_Click);
            // 
            // cboChonTang
            // 
            this.cboChonTang.FormattingEnabled = true;
            this.cboChonTang.Location = new System.Drawing.Point(274, 17);
            this.cboChonTang.Name = "cboChonTang";
            this.cboChonTang.Size = new System.Drawing.Size(194, 28);
            this.cboChonTang.TabIndex = 5;
            this.cboChonTang.SelectedIndexChanged += new System.EventHandler(this.cboChonTang_SelectedIndexChanged);
            // 
            // txtTenTang
            // 
            this.txtTenTang.Location = new System.Drawing.Point(927, 19);
            this.txtTenTang.Name = "txtTenTang";
            this.txtTenTang.Size = new System.Drawing.Size(190, 26);
            this.txtTenTang.TabIndex = 4;
            // 
            // txtMaTang
            // 
            this.txtMaTang.Location = new System.Drawing.Point(607, 19);
            this.txtMaTang.Name = "txtMaTang";
            this.txtMaTang.Size = new System.Drawing.Size(166, 26);
            this.txtMaTang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên tầng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã tầng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn tầng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(458, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SỐ TẦNG VÀ THIẾT BỊ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(6, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1304, 505);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết bị";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvThietBi);
            this.panel3.Location = new System.Drawing.Point(432, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 474);
            this.panel3.TabIndex = 1;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(3, 3);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.Size = new System.Drawing.Size(863, 468);
            this.dgvThietBi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudTienBDTB);
            this.panel2.Controls.Add(this.nudTienMuaTB);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnLuuTB);
            this.panel2.Controls.Add(this.btnXoaTB);
            this.panel2.Controls.Add(this.btnSuaTB);
            this.panel2.Controls.Add(this.btnThemTB);
            this.panel2.Controls.Add(this.nudSoLuongTB);
            this.panel2.Controls.Add(this.dtpNgayBDTB);
            this.panel2.Controls.Add(this.dtpNgayMuaTB);
            this.panel2.Controls.Add(this.txtTrangThaiTB);
            this.panel2.Controls.Add(this.txtTenTB);
            this.panel2.Controls.Add(this.txtMaTB);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 474);
            this.panel2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(220, 422);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 38);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuTB
            // 
            this.btnLuuTB.Location = new System.Drawing.Point(75, 422);
            this.btnLuuTB.Name = "btnLuuTB";
            this.btnLuuTB.Size = new System.Drawing.Size(102, 38);
            this.btnLuuTB.TabIndex = 19;
            this.btnLuuTB.Text = "Lưu";
            this.btnLuuTB.UseVisualStyleBackColor = true;
            this.btnLuuTB.Click += new System.EventHandler(this.btnLuuTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Location = new System.Drawing.Point(280, 358);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(102, 38);
            this.btnXoaTB.TabIndex = 18;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.UseVisualStyleBackColor = true;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Location = new System.Drawing.Point(151, 358);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(102, 38);
            this.btnSuaTB.TabIndex = 17;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.UseVisualStyleBackColor = true;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // btnThemTB
            // 
            this.btnThemTB.Location = new System.Drawing.Point(22, 358);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(102, 38);
            this.btnThemTB.TabIndex = 16;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.UseVisualStyleBackColor = true;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // nudSoLuongTB
            // 
            this.nudSoLuongTB.Location = new System.Drawing.Point(160, 93);
            this.nudSoLuongTB.Name = "nudSoLuongTB";
            this.nudSoLuongTB.Size = new System.Drawing.Size(237, 26);
            this.nudSoLuongTB.TabIndex = 15;
            // 
            // dtpNgayBDTB
            // 
            this.dtpNgayBDTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBDTB.Location = new System.Drawing.Point(160, 173);
            this.dtpNgayBDTB.Name = "dtpNgayBDTB";
            this.dtpNgayBDTB.Size = new System.Drawing.Size(237, 26);
            this.dtpNgayBDTB.TabIndex = 14;
            // 
            // dtpNgayMuaTB
            // 
            this.dtpNgayMuaTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuaTB.Location = new System.Drawing.Point(160, 129);
            this.dtpNgayMuaTB.Name = "dtpNgayMuaTB";
            this.dtpNgayMuaTB.Size = new System.Drawing.Size(237, 26);
            this.dtpNgayMuaTB.TabIndex = 13;
            // 
            // txtTrangThaiTB
            // 
            this.txtTrangThaiTB.Location = new System.Drawing.Point(160, 214);
            this.txtTrangThaiTB.Name = "txtTrangThaiTB";
            this.txtTrangThaiTB.Size = new System.Drawing.Size(237, 26);
            this.txtTrangThaiTB.TabIndex = 12;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(160, 54);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(237, 26);
            this.txtTenTB.TabIndex = 9;
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(160, 15);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(237, 26);
            this.txtMaTB.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tiền bảo dưỡng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tiền mua:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày bảo dưỡng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày mua:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên thiết bị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã thiết bị:";
            // 
            // nudTienMuaTB
            // 
            this.nudTienMuaTB.Location = new System.Drawing.Point(160, 255);
            this.nudTienMuaTB.Name = "nudTienMuaTB";
            this.nudTienMuaTB.Size = new System.Drawing.Size(237, 26);
            this.nudTienMuaTB.TabIndex = 21;
            // 
            // nudTienBDTB
            // 
            this.nudTienBDTB.Location = new System.Drawing.Point(160, 297);
            this.nudTienBDTB.Name = "nudTienBDTB";
            this.nudTienBDTB.Size = new System.Drawing.Size(237, 26);
            this.nudTienBDTB.TabIndex = 22;
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThietBi";
            this.Text = "Quản lý tầng & thiết bị";
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMuaTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienBDTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboChonTang;
        private System.Windows.Forms.TextBox txtTenTang;
        private System.Windows.Forms.TextBox txtMaTang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSuaTang;
        private System.Windows.Forms.Button btnXoaTang;
        private System.Windows.Forms.Button btnThemTang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrangThaiTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.NumericUpDown nudSoLuongTB;
        private System.Windows.Forms.DateTimePicker dtpNgayBDTB;
        private System.Windows.Forms.DateTimePicker dtpNgayMuaTB;
        private System.Windows.Forms.Button btnLuuTang;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuuTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.NumericUpDown nudTienBDTB;
        private System.Windows.Forms.NumericUpDown nudTienMuaTB;
    }
}