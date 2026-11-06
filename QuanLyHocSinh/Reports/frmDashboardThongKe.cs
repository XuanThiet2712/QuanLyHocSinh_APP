using QLSV.Models;
using QLSV.Services;
using QuanLyHocSinh.Models;
using QuanLyHocSinh.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyHocSinh.Forms.Reports
{
    public partial class frmDashboardThongKe : Form
    {
        private readonly GradeService grade = new GradeService();

        public frmDashboardThongKe()
        {
            InitializeComponent();
        }

        private void frmDashboardThongKe_Load(object sender, EventArgs e)
        {
            cboLoaiBieuDo.SelectedIndex = 0;   // Doughnut
            VeTatCa();
        }

        private void VeTatCa()
        {
            VeXepLoai();

            VeBieuDo(chartDiemLop, grade.DiemTrungBinhTheoLop(),
                SeriesChartType.Column, "Điểm trung bình theo lớp");

            List<ThongKeDTO> top = grade.TopSinhVien(5);
            top.Reverse();   // biểu đồ Bar vẽ phần tử đầu ở dưới cùng, đảo lại để người đứng đầu nằm trên
            VeBieuDo(chartTop, top, SeriesChartType.Bar, "Top 5 sinh viên theo GPA");

            VeBieuDo(chartDangKy, grade.DangKyTheoNgay(),
                SeriesChartType.Line, "Lượt đăng ký theo ngày");

            VeBieuDo(chartPhoDiem, grade.PhoDiem(),
                SeriesChartType.Area, "Phổ điểm");

            VeBieuDo(chartDiemMon, grade.DiemTrungBinhTheoMon(),
                SeriesChartType.Radar, "Điểm trung bình theo môn");
        }

        private void VeXepLoai()
        {
            SeriesChartType loai;
            Enum.TryParse(cboLoaiBieuDo.Text, out loai);
            VeBieuDo(chartXepLoai, grade.PhoXepLoai(), loai, "Tỷ lệ xếp loại");
        }

        // MỘT hàm vẽ dùng chung cho mọi biểu đồ
        private void VeBieuDo(Chart chart, List<ThongKeDTO> duLieu,
                              SeriesChartType loai, string tieuDe)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add(tieuDe);

            var s = new Series("dl")
            {
                ChartType = loai,
                IsValueShownAsLabel = true
            };

            bool laTron = (loai == SeriesChartType.Pie || loai == SeriesChartType.Doughnut);
            if (laTron)
            {
                s.Label = "#PERCENT{P0}";   // hiện phần trăm
                s.LegendText = "#VALX";      // chú thích lấy theo nhãn
            }
            else
            {
                s.Label = "#VAL{0.##}";      // tối đa 2 chữ số thập phân
            }

            foreach (ThongKeDTO d in duLieu)
                s.Points.AddXY(d.Nhan, d.GiaTri);

            chart.Series.Add(s);

            if (chart.Legends.Count > 0)
                chart.Legends[0].Enabled = laTron;   // chỉ biểu đồ tròn cần chú thích

            if (chart.ChartAreas.Count > 0)
                chart.ChartAreas[0].AxisX.Interval = 1;   // hiện đủ nhãn trục X
        }

        private void cboLoaiBieuDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiBieuDo.Text != "") VeXepLoai();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            VeTatCa();
        }
    }
}