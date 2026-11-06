namespace QuanLyHocSinh.Forms.Reports
{
    partial class frmDashboardThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartXepLoai = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiBieuDo = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartDangKy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPhoDiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDiemMon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDiemLop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartXepLoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhoDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiemMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiemLop)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartXepLoai
            // 
            chartArea7.Name = "ChartArea1";
            this.chartXepLoai.ChartAreas.Add(chartArea7);
            this.chartXepLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chartXepLoai.Legends.Add(legend7);
            this.chartXepLoai.Location = new System.Drawing.Point(0, 0);
            this.chartXepLoai.Name = "chartXepLoai";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartXepLoai.Series.Add(series7);
            this.chartXepLoai.Size = new System.Drawing.Size(200, 167);
            this.chartXepLoai.TabIndex = 0;
            this.chartXepLoai.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartXepLoai);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 167);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biểu đồ tỉ lệ";
            // 
            // cboLoaiBieuDo
            // 
            this.cboLoaiBieuDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBieuDo.FormattingEnabled = true;
            this.cboLoaiBieuDo.Items.AddRange(new object[] {
            "Doughnut",
            "Pie",
            "Column"});
            this.cboLoaiBieuDo.Location = new System.Drawing.Point(636, 37);
            this.cboLoaiBieuDo.Name = "cboLoaiBieuDo";
            this.cboLoaiBieuDo.Size = new System.Drawing.Size(134, 21);
            this.cboLoaiBieuDo.TabIndex = 2;
            this.cboLoaiBieuDo.SelectedIndexChanged += new System.EventHandler(this.cboLoaiBieuDo_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(636, 272);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(121, 86);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartDangKy, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartPhoDiem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartDiemMon, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartTop, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartDiemLop, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 346);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chartDangKy
            // 
            chartArea8.Name = "ChartArea1";
            this.chartDangKy.ChartAreas.Add(chartArea8);
            this.chartDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.chartDangKy.Legends.Add(legend8);
            this.chartDangKy.Location = new System.Drawing.Point(3, 176);
            this.chartDangKy.Name = "chartDangKy";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartDangKy.Series.Add(series8);
            this.chartDangKy.Size = new System.Drawing.Size(200, 167);
            this.chartDangKy.TabIndex = 3;
            this.chartDangKy.Text = "chart3";
            // 
            // chartPhoDiem
            // 
            chartArea9.Name = "ChartArea1";
            this.chartPhoDiem.ChartAreas.Add(chartArea9);
            this.chartPhoDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.chartPhoDiem.Legends.Add(legend9);
            this.chartPhoDiem.Location = new System.Drawing.Point(209, 176);
            this.chartPhoDiem.Name = "chartPhoDiem";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartPhoDiem.Series.Add(series9);
            this.chartPhoDiem.Size = new System.Drawing.Size(200, 167);
            this.chartPhoDiem.TabIndex = 4;
            this.chartPhoDiem.Text = "chart4";
            // 
            // chartDiemMon
            // 
            chartArea10.Name = "ChartArea1";
            this.chartDiemMon.ChartAreas.Add(chartArea10);
            this.chartDiemMon.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartDiemMon.Legends.Add(legend10);
            this.chartDiemMon.Location = new System.Drawing.Point(415, 176);
            this.chartDiemMon.Name = "chartDiemMon";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartDiemMon.Series.Add(series10);
            this.chartDiemMon.Size = new System.Drawing.Size(175, 167);
            this.chartDiemMon.TabIndex = 5;
            this.chartDiemMon.Text = "chart5";
            // 
            // chartTop
            // 
            chartArea11.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea11);
            this.chartTop.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.chartTop.Legends.Add(legend11);
            this.chartTop.Location = new System.Drawing.Point(415, 3);
            this.chartTop.Name = "chartTop";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartTop.Series.Add(series11);
            this.chartTop.Size = new System.Drawing.Size(175, 167);
            this.chartTop.TabIndex = 6;
            this.chartTop.Text = "chart6";
            // 
            // chartDiemLop
            // 
            chartArea12.Name = "ChartArea1";
            this.chartDiemLop.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartDiemLop.Legends.Add(legend12);
            this.chartDiemLop.Location = new System.Drawing.Point(209, 3);
            this.chartDiemLop.Name = "chartDiemLop";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartDiemLop.Series.Add(series12);
            this.chartDiemLop.Size = new System.Drawing.Size(200, 167);
            this.chartDiemLop.TabIndex = 7;
            this.chartDiemLop.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 382);
            this.panel2.TabIndex = 4;
            // 
            // frmDashboardThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cboLoaiBieuDo);
            this.Name = "frmDashboardThongKe";
            this.Text = "frmDashboardThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartXepLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhoDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiemMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiemLop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartXepLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiBieuDo;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDangKy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhoDiem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiemMon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiemLop;
    }
}