using QuanLyHocSinh.Models;
using QuanLyHocSinh.Services;
using QuanLyHocSinh.Models;
using QuanLyHocSinh.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLSV.Services;

namespace QuanLyHocSinh.Forms.Grade
{
    public partial class frmNhapDiem : Form
    {
        private readonly EnrollService enroll = new EnrollService();   // của người C
        private readonly GradeService grade = new GradeService();      // của người D

        private List<DiemDTO> dsDiem = null;     // danh sách đang sửa trên lưới
        private string maLHPHienTai = null;
        private bool dangNap = true;

        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            dgvDiem.AutoGenerateColumns = false;
            dgvLHP.AutoGenerateColumns = false;

            cboHocKy.DataSource = enroll.LayDanhSachHocKy();
            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "MaHocKy";

            dangNap = false;
            TaiLaiLop();
        }

        private void TaiLaiLop()
        {
            string maHocKy = cboHocKy.SelectedValue as string;
            if (maHocKy == null) return;

            dgvDiem.DataSource = enroll.LayLopHocPhan(maHocKy);
            dgvLHP.DataSource = null;
            dsDiem = null;
            maLHPHienTai = null;
            lblThongTin.Text = "Hãy chọn một lớp học phần";
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangNap) TaiLaiLop();
        }

        // Bấm vào một lớp: nạp danh sách sinh viên và điểm của lớp đó
        private void dgvLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var lop = dgvDiem.Rows[e.RowIndex].DataBoundItem as LopHocPhanDTO;
            if (lop == null) return;

            maLHPHienTai = lop.MaLHP;
            dsDiem = grade.LayDanhSachDiem(lop.MaLHP);
            dgvLHP.DataSource = dsDiem;
            lblThongTin.Text = "Lớp " + lop.MaLHP + " - " + lop.TenMon + " (" + dsDiem.Count + " sinh viên)";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dsDiem == null || maLHPHienTai == null)
            {
                MessageBox.Show("Hãy chọn lớp học phần trước");
                return;
            }

            dgvLHP.EndEdit();   // chốt ô đang gõ dở

            string loi = grade.LuuDiem(maLHPHienTai, dsDiem);
            if (loi != null)
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Đã lưu điểm", "Thành công");
        }

        // Người dùng gõ chữ không phải số vào ô điểm
        private void dgvDiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Điểm phải là một số, ví dụ 8,5", "Giá trị không hợp lệ");
            e.ThrowException = false;
            e.Cancel = false;
        }
    }
}