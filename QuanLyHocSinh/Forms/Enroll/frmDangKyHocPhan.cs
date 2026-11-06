using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLSV.Models;
using QLSV.Services;

namespace QuanLyHocSinh.Forms.Enroll
{
    public partial class frmDangKyHocPhan : Form
    {
        private readonly EnrollService enroll = new EnrollService();
        private readonly CatalogService catalog = new CatalogService();
        private string maSVHienTai = null;   // sinh viên đã kiểm tra hợp lệ
        private bool dangNap = true;

        public frmDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void frmDangKyHocPhan_Load(object sender, EventArgs e)
        {
            dgvLHP.AutoGenerateColumns = false;
            dgvDaDangKy.AutoGenerateColumns = false;

            cboHocKy.DataSource = enroll.LayDanhSachHocKy();
            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "MaHocKy";

            dangNap = false;
            TaiLaiLuoi();
        }

        private string MaHocKy
        {
            get { return cboHocKy.SelectedValue as string; }
        }

        // Nạp lại cả hai lưới và tổng tín chỉ
        private void TaiLaiLuoi()
        {
            if (MaHocKy == null) return;

            dgvLHP.DataSource = enroll.LayLopHocPhan(MaHocKy);

            if (maSVHienTai != null)
            {
                dgvDaDangKy.DataSource = enroll.LayHocPhanDaDangKy(maSVHienTai, MaHocKy);
                int tc = enroll.TinhTongTinChi(maSVHienTai, MaHocKy);
                lblTongTC.Text = "Tổng tín chỉ: " + tc + "/" + EnrollService.TIN_CHI_TOI_DA;
            }
            else
            {
                dgvDaDangKy.DataSource = null;
                lblTongTC.Text = "Tổng tín chỉ: 0/" + EnrollService.TIN_CHI_TOI_DA;
            }
        }

        // ===== Kiểm tra sinh viên =====
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = catalog.LaySinhVienTheoMa(txtMaSV.Text.Trim());
            if (sv == null)
            {
                maSVHienTai = null;
                lblHoTen.Text = "";
                MessageBox.Show("Không tìm thấy sinh viên", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                maSVHienTai = sv.MaSV;
                lblHoTen.Text = sv.HoTen + " - " + sv.TenLop;
            }
            TaiLaiLuoi();
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangNap) TaiLaiLuoi();
        }

        // ===== Đăng ký =====
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (maSVHienTai == null)
            {
                MessageBox.Show("Hãy nhập mã sinh viên rồi bấm Kiểm tra");
                return;
            }

            dgvLHP.EndEdit();   // chốt giá trị ô tick đang sửa dở

            var dsChon = new List<string>();
            foreach (DataGridViewRow r in dgvLHP.Rows)
            {
                bool daTick = Convert.ToBoolean(r.Cells["colChon"].Value ?? false);
                if (daTick)
                    dsChon.Add(r.Cells["colMaLHP"].Value.ToString());
            }

            string loi = enroll.DangKyNhieu(maSVHienTai, dsChon);
            if (loi != null)
            {
                MessageBox.Show(loi + "\n\nKhông có lớp nào được đăng ký.", "Không thể đăng ký",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Đã đăng ký " + dsChon.Count + " lớp học phần", "Thành công");
            TaiLaiLuoi();
        }

        // ===== Hủy đăng ký =====
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (maSVHienTai == null || dgvDaDangKy.CurrentRow == null) return;

            var dk = dgvDaDangKy.CurrentRow.DataBoundItem as DangKyDTO;
            if (dk == null) return;

            DialogResult r = MessageBox.Show("Hủy đăng ký lớp " + dk.MaLHP + " - " + dk.TenMon + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            string loi = enroll.HuyDangKy(maSVHienTai, dk.MaLHP);
            if (loi != null)
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TaiLaiLuoi();
        }
    }
}