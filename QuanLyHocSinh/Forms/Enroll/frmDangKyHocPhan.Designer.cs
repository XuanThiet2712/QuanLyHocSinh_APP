namespace QuanLyHocSinh.Forms.Enroll
{
    partial class frmDangKyHocPhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongTC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLHP = new System.Windows.Forms.DataGridView();
            this.dgvDaDangKy = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.colDKMaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDKTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDKTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDKLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDKNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDKDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên : ";
            // 
            // lblTongTC
            // 
            this.lblTongTC.AutoSize = true;
            this.lblTongTC.Location = new System.Drawing.Point(415, 48);
            this.lblTongTC.Name = "lblTongTC";
            this.lblTongTC.Size = new System.Drawing.Size(35, 13);
            this.lblTongTC.TabIndex = 4;
            this.lblTongTC.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danh sách các lớp học phần";
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(76, 40);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(111, 21);
            this.cboHocKy.TabIndex = 6;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(347, 19);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(48, 13);
            this.lblHoTen.TabIndex = 7;
            this.lblHoTen.Text = "Họ tên : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tín chỉ :";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(592, 158);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(191, 44);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "đăng ký các lớp đã chọn";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Học phần đã đăng ký";
            // 
            // dgvLHP
            // 
            this.dgvLHP.AllowUserToAddRows = false;
            this.dgvLHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLHP,
            this.colTenMon,
            this.colTinChi,
            this.colGV,
            this.colLich,
            this.colSiSo});
            this.dgvLHP.Location = new System.Drawing.Point(12, 106);
            this.dgvLHP.Name = "dgvLHP";
            this.dgvLHP.ReadOnly = true;
            this.dgvLHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLHP.Size = new System.Drawing.Size(538, 112);
            this.dgvLHP.TabIndex = 11;
            // 
            // dgvDaDangKy
            // 
            this.dgvDaDangKy.AllowUserToAddRows = false;
            this.dgvDaDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDKMaLHP,
            this.colDKTenMon,
            this.colDKTinChi,
            this.colDKLich,
            this.colDKNgay,
            this.colDKDiem});
            this.dgvDaDangKy.Location = new System.Drawing.Point(11, 269);
            this.dgvDaDangKy.MultiSelect = false;
            this.dgvDaDangKy.Name = "dgvDaDangKy";
            this.dgvDaDangKy.ReadOnly = true;
            this.dgvDaDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaDangKy.Size = new System.Drawing.Size(539, 97);
            this.dgvDaDangKy.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(592, 247);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(191, 44);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Huyr ddanwg kys lop da chon";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(652, 106);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(115, 35);
            this.btnKiemTra.TabIndex = 14;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(76, 14);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(120, 20);
            this.txtMaSV.TabIndex = 15;
            // 
            // colDKMaLHP
            // 
            this.colDKMaLHP.DataPropertyName = "MaLHP";
            this.colDKMaLHP.HeaderText = "Mã lớp";
            this.colDKMaLHP.Name = "colDKMaLHP";
            this.colDKMaLHP.ReadOnly = true;
            // 
            // colDKTenMon
            // 
            this.colDKTenMon.DataPropertyName = "TenMon";
            this.colDKTenMon.HeaderText = "Môn học";
            this.colDKTenMon.Name = "colDKTenMon";
            this.colDKTenMon.ReadOnly = true;
            // 
            // colDKTinChi
            // 
            this.colDKTinChi.DataPropertyName = "SoTinChi";
            this.colDKTinChi.HeaderText = "Tín chỉ";
            this.colDKTinChi.Name = "colDKTinChi";
            this.colDKTinChi.ReadOnly = true;
            // 
            // colDKLich
            // 
            this.colDKLich.DataPropertyName = "Lich";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.colDKLich.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDKLich.HeaderText = "Lịch học";
            this.colDKLich.Name = "colDKLich";
            this.colDKLich.ReadOnly = true;
            // 
            // colDKNgay
            // 
            this.colDKNgay.DataPropertyName = "NgayDK";
            this.colDKNgay.HeaderText = "Ngày đăng ký";
            this.colDKNgay.Name = "colDKNgay";
            this.colDKNgay.ReadOnly = true;
            // 
            // colDKDiem
            // 
            this.colDKDiem.DataPropertyName = "DiemSo";
            this.colDKDiem.HeaderText = "Điểm";
            this.colDKDiem.Name = "colDKDiem";
            this.colDKDiem.ReadOnly = true;
            // 
            // colMaLHP
            // 
            this.colMaLHP.DataPropertyName = "MaLHP";
            this.colMaLHP.HeaderText = "Mã lớp";
            this.colMaLHP.Name = "colMaLHP";
            this.colMaLHP.ReadOnly = true;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.HeaderText = "Môn học";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colTinChi
            // 
            this.colTinChi.DataPropertyName = "SoTinChi";
            this.colTinChi.HeaderText = "Tín chỉ";
            this.colTinChi.Name = "colTinChi";
            this.colTinChi.ReadOnly = true;
            // 
            // colGV
            // 
            this.colGV.DataPropertyName = "TenGV";
            this.colGV.HeaderText = "Giảng viên";
            this.colGV.Name = "colGV";
            this.colGV.ReadOnly = true;
            // 
            // colLich
            // 
            this.colLich.DataPropertyName = "Lich";
            this.colLich.HeaderText = "Lịch học";
            this.colLich.Name = "colLich";
            this.colLich.ReadOnly = true;
            // 
            // colSiSo
            // 
            this.colSiSo.DataPropertyName = "SiSo";
            this.colSiSo.HeaderText = "Sĩ số";
            this.colSiSo.Name = "colSiSo";
            this.colSiSo.ReadOnly = true;
            // 
            // frmDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 378);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvDaDangKy);
            this.Controls.Add(this.dgvLHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyHocPhan";
            this.Text = "frmDangKyHocPhan";
            this.Load += new System.EventHandler(this.frmDangKyHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLHP;
        private System.Windows.Forms.DataGridView dgvDaDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDKMaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDKTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDKTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDKLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDKNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDKDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
    }
}