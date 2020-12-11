namespace GUI_QUANLIHANGHOA
{
    partial class frmThanhVien
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtSoThich = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenThanhVien = new System.Windows.Forms.TextBox();
            this.txtMaThanhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.mathanhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthanhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soThich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtSoThich);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.txtTenThanhVien);
            this.grpThongTin.Controls.Add(this.txtMaThanhVien);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Location = new System.Drawing.Point(5, 5);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(362, 260);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Thành Viên";
            // 
            // txtSoThich
            // 
            this.txtSoThich.Location = new System.Drawing.Point(117, 184);
            this.txtSoThich.Multiline = true;
            this.txtSoThich.Name = "txtSoThich";
            this.txtSoThich.Size = new System.Drawing.Size(200, 20);
            this.txtSoThich.TabIndex = 12;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 108);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa Chỉ";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(117, 146);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(200, 21);
            this.cboGioiTinh.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sở Thích";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(117, 222);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // txtTenThanhVien
            // 
            this.txtTenThanhVien.Location = new System.Drawing.Point(117, 70);
            this.txtTenThanhVien.Name = "txtTenThanhVien";
            this.txtTenThanhVien.Size = new System.Drawing.Size(200, 20);
            this.txtTenThanhVien.TabIndex = 4;
            // 
            // txtMaThanhVien
            // 
            this.txtMaThanhVien.Location = new System.Drawing.Point(117, 32);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.Size = new System.Drawing.Size(200, 20);
            this.txtMaThanhVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thành Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thành Viên";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(463, 126);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(102, 31);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AllowUserToOrderColumns = true;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathanhvien,
            this.tenthanhvien,
            this.gioitinh,
            this.maloai,
            this.soThich,
            this.diaChi});
            this.dgvThanhVien.Location = new System.Drawing.Point(5, 271);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.Size = new System.Drawing.Size(639, 441);
            this.dgvThanhVien.TabIndex = 5;
            // 
            // mathanhvien
            // 
            this.mathanhvien.DataPropertyName = "mathanhvien";
            this.mathanhvien.HeaderText = "Mã Thành Viên";
            this.mathanhvien.Name = "mathanhvien";
            this.mathanhvien.ReadOnly = true;
            // 
            // tenthanhvien
            // 
            this.tenthanhvien.DataPropertyName = "tenthanhvien";
            this.tenthanhvien.HeaderText = "Tên Thành Viên";
            this.tenthanhvien.Name = "tenthanhvien";
            this.tenthanhvien.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "ngaysinh";
            this.maloai.HeaderText = "Ngày Sinh";
            this.maloai.Name = "maloai";
            this.maloai.ReadOnly = true;
            // 
            // soThich
            // 
            this.soThich.DataPropertyName = "sothich";
            this.soThich.HeaderText = "Sở Thích";
            this.soThich.Name = "soThich";
            this.soThich.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diachi";
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // frmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 574);
            this.Controls.Add(this.dgvThanhVien);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "frmThanhVien";
            this.Text = "Quản lí hàng hóa";
            this.Load += new System.EventHandler(this.frmThanhVien_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenThanhVien;
        private System.Windows.Forms.TextBox txtMaThanhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoThich;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathanhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthanhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soThich;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
    }
}

