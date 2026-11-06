namespace QuanLyHocSinh.Forms.Grade
{
    partial class frmNhapDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.dgvLHP = new System.Windows.Forms.DataGridView();
            this.colMaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(146, 26);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(150, 21);
            this.cboHocKy.TabIndex = 0;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hojc kyf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "chon lop hoc phan";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colTenLop,
            this.colDiem});
            this.dgvDiem.Location = new System.Drawing.Point(19, 269);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(540, 100);
            this.dgvDiem.TabIndex = 3;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLHP_CellClick);
            // 
            // colMaSV
            // 
            this.colMaSV.DataPropertyName = "MaSV";
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Hoj ten ";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colTenLop
            // 
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Lop";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.DataPropertyName = "DiemSo";
            dataGridViewCellStyle4.NullValue = "0.0";
            this.colDiem.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiem.HeaderText = "Diem";
            this.colDiem.Name = "colDiem";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(653, 373);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 35);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Location = new System.Drawing.Point(16, 243);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(96, 13);
            this.lblThongTin.TabIndex = 6;
            this.lblThongTin.Text = "chon lop hoc phan";
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
            this.dgvLHP.Location = new System.Drawing.Point(21, 107);
            this.dgvLHP.Name = "dgvLHP";
            this.dgvLHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLHP.Size = new System.Drawing.Size(538, 112);
            this.dgvLHP.TabIndex = 12;
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
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLHP);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHocKy);
            this.Name = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridView dgvLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
    }
}