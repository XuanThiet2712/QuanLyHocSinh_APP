using QLSV.Models;
using QLSV.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLSV.Forms.Catalog
{
    public partial class frmSinhVien : Form
    {
        private readonly CatalogService svc = new CatalogService();
        private bool dangNap = true;   // cờ chặn sự kiện khi đang nạp dữ liệu ban đầu

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = svc.LayDanhSachLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";

            List<LopDTO> dsLoc = svc.LayDanhSachLop();
            dsLoc.Insert(0, new LopDTO { MaLop = "", TenLop = "-- Tất cả --" });
            cboLocLop.DataSource = dsLoc;
            cboLocLop.DisplayMember = "TenLop";
            cboLocLop.ValueMember = "MaLop";

            cboGioiTinh.SelectedIndex = 0;

            dangNap = false;
            TaiLaiLuoi();
        }

        // ===== Hàm dùng chung =====
        private void TaiLaiLuoi()
        {
            dgvSinhVien.DataSource = svc.LayDanhSachSinhVien(
                cboLocLop.SelectedValue as string, txtTimKiem.Text);
        }

        private SinhVienDTO LayTuForm()
        {
            return new SinhVienDTO
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = cboGioiTinh.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                MaLop = cboLop.SelectedValue as string
            };
        }

        private void LamMoiForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            txtMaSV.ReadOnly = false;
            txtMaSV.Focus();
        }

        // Hiển thị kết quả: lỗi (khác null) thì báo lỗi, ngược lại báo thành công
        private void XuLyKetQua(string loi, string thongBaoThanhCong)
        {
            if (loi != null)
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(thongBaoThanhCong, "Thành công");
            TaiLaiLuoi();
            LamMoiForm();
        }

        // ===== Các nút =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            XuLyKetQua(svc.ThemSinhVien(LayTuForm()), "Đã thêm sinh viên");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            XuLyKetQua(svc.SuaSinhVien(LayTuForm()), "Đã cập nhật sinh viên");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Hãy chọn sinh viên cần xóa trên lưới");
                return;
            }
            DialogResult r = MessageBox.Show("Xóa sinh viên " + txtMaSV.Text + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            XuLyKetQua(svc.XoaSinhVien(txtMaSV.Text.Trim()), "Đã xóa sinh viên");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        // ===== Lọc và tìm kiếm =====
        private void cboLocLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangNap) TaiLaiLuoi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (!dangNap) TaiLaiLuoi();
        }

        // ===== Bấm dòng trên lưới: đổ dữ liệu lên các ô =====
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var sv = dgvSinhVien.Rows[e.RowIndex].DataBoundItem as SinhVienDTO;
            if (sv == null) return;

            txtMaSV.Text = sv.MaSV;
            txtMaSV.ReadOnly = true;     // không cho sửa mã khi đang ở chế độ sửa
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh ?? DateTime.Today;
            cboGioiTinh.Text = sv.GioiTinh;
            txtDiaChi.Text = sv.DiaChi;
            txtEmail.Text = sv.Email;
            cboLop.SelectedValue = sv.MaLop;
        }
    }
}