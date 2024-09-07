namespace GUI
{
    partial class frmPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoiThat = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.cbMaTang = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbConTrong = new System.Windows.Forms.RadioButton();
            this.rbDaChoThue = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(382, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý phòng trọ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.mansion;
            this.pictureBox1.Location = new System.Drawing.Point(34, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPhong);
            this.panel2.Location = new System.Drawing.Point(299, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 436);
            this.panel2.TabIndex = 1;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(3, 3);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(736, 430);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoiThat);
            this.groupBox1.Controls.Add(this.txtGiaPhong);
            this.groupBox1.Controls.Add(this.cbMaTang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txtLoaiPhong);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbConTrong);
            this.groupBox1.Controls.Add(this.rbDaChoThue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(294, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtNoiThat
            // 
            this.txtNoiThat.Location = new System.Drawing.Point(82, 273);
            this.txtNoiThat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoiThat.Multiline = true;
            this.txtNoiThat.Name = "txtNoiThat";
            this.txtNoiThat.Size = new System.Drawing.Size(208, 25);
            this.txtNoiThat.TabIndex = 18;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(82, 235);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaPhong.Multiline = true;
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(208, 25);
            this.txtGiaPhong.TabIndex = 17;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(82, 114);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenPhong.Multiline = true;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(208, 25);
            this.txtTenPhong.TabIndex = 16;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(82, 195);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoaiPhong.Multiline = true;
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(208, 25);
            this.txtLoaiPhong.TabIndex = 15;
            // 
            // cbMaTang
            // 
            this.cbMaTang.FormattingEnabled = true;
            this.cbMaTang.Location = new System.Drawing.Point(82, 35);
            this.cbMaTang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaTang.Name = "cbMaTang";
            this.cbMaTang.Size = new System.Drawing.Size(208, 28);
            this.cbMaTang.TabIndex = 14;
            this.cbMaTang.SelectedIndexChanged += new System.EventHandler(this.cbMaTang_SelectedIndexChanged);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(82, 74);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(208, 25);
            this.txtMaPhong.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Chọn tầng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nội thất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giá phòng:";
            // 
            // rbConTrong
            // 
            this.rbConTrong.AutoSize = true;
            this.rbConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConTrong.Location = new System.Drawing.Point(181, 159);
            this.rbConTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbConTrong.Name = "rbConTrong";
            this.rbConTrong.Size = new System.Drawing.Size(71, 17);
            this.rbConTrong.TabIndex = 5;
            this.rbConTrong.TabStop = true;
            this.rbConTrong.Text = "Còn trống";
            this.rbConTrong.UseVisualStyleBackColor = true;
            // 
            // rbDaChoThue
            // 
            this.rbDaChoThue.AutoSize = true;
            this.rbDaChoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDaChoThue.Location = new System.Drawing.Point(94, 158);
            this.rbDaChoThue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDaChoThue.Name = "rbDaChoThue";
            this.rbDaChoThue.Size = new System.Drawing.Size(84, 17);
            this.rbDaChoThue.TabIndex = 4;
            this.rbDaChoThue.TabStop = true;
            this.rbDaChoThue.Text = "Đã cho thuê";
            this.rbDaChoThue.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng Thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnQuayLai);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(1, 437);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 121);
            this.panel3.TabIndex = 2;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::GUI.Properties.Resources.icons8_export_24;
            this.btnQuayLai.Location = new System.Drawing.Point(150, 72);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(119, 33);
            this.btnQuayLai.TabIndex = 23;
            this.btnQuayLai.Text = "Trang chủ";
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::GUI.Properties.Resources.icons8_refresh_24;
            this.btnRefresh.Location = new System.Drawing.Point(20, 72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 33);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Lưu";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_delete_24;
            this.btnXoa.Location = new System.Drawing.Point(208, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 33);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_fix_24;
            this.btnSua.Location = new System.Drawing.Point(110, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 33);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_24;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(9, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 33);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhong";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDaChoThue;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbConTrong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ComboBox cbMaTang;
        private System.Windows.Forms.TextBox txtNoiThat;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}