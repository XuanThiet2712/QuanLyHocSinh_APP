using Microsoft.Reporting.WinForms;
using QLSV.Models;
using QLSV.Services;
using QuanLyHocSinh.Services;
using System;
using System.Windows.Forms;

namespace QLSV.Forms.Report
{
    public partial class frmReportBangDiem : Form
    {
        private readonly CatalogService catalog = new CatalogService();   // người B
        private readonly GradeService grade = new GradeService();         // người D

        public frmReportBangDiem()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = catalog.LaySinhVienTheoMa(txtMaSV.Text.Trim());
            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dsDiem = grade.LayBangDiem(sv.MaSV);
            double gpa = grade.TinhGPA(sv.MaSV);

            ReportParameter[] ps = new ReportParameter[]
            {
                new ReportParameter("pMaSV", sv.MaSV),
                new ReportParameter("pHoTen", sv.HoTen),
                new ReportParameter("pLop", sv.TenLop ?? ""),
                new ReportParameter("pGPA", gpa.ToString("0.00")),
                new ReportParameter("pXepLoai", GradeService.XepLoai(gpa)),
                new ReportParameter("pNgayIn", DateTime.Now.ToString("dd/MM/yyyy"))
            };

            var lr = reportViewer1.LocalReport;
            lr.ReportEmbeddedResource = "QLSV.Reports.rptBangDiem.rdlc";
            lr.DataSources.Clear();
            lr.DataSources.Add(new ReportDataSource("dsBangDiem", dsDiem));
            lr.SetParameters(ps);
            reportViewer1.RefreshReport();
        }
    }
}