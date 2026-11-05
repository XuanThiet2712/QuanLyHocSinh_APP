using QLSV.Models;
using QuanLyHocSinh;
using System.Collections.Generic;
using System.Linq;

namespace QLSV.Services
{
    public class CatalogService
    {
        // ===== Lớp =====
        public List<LopDTO> LayDanhSachLop()
        {
            using (var db = new QLSVDataContext())
            {
                return db.Lops
                    .OrderBy(p => p.TenLop)
                    .Select(p => new LopDTO { MaLop = p.MaLop, TenLop = p.TenLop })
                    .ToList();
            }
        }

        // ===== Sinh viên =====
        public List<SinhVienDTO> LayDanhSachSinhVien(string maLop, string tuKhoa)
        {
            using (var db = new QLSVDataContext())
            {
                tuKhoa = (tuKhoa ?? "").Trim();

                var q = db.SinhViens
                    .Where(p => p.HoTen.Contains(tuKhoa) || p.MaSV.Contains(tuKhoa));

                if (!string.IsNullOrEmpty(maLop))
                    q = q.Where(p => p.MaLop == maLop);

                return q.OrderBy(p => p.MaSV)
                    .Select(p => new SinhVienDTO
                    {
                        MaSV = p.MaSV,
                        HoTen = p.HoTen,
                        NgaySinh = p.NgaySinh,
                        GioiTinh = p.GioiTinh,
                        DiaChi = p.DiaChi,
                        Email = p.Email,
                        MaLop = p.MaLop,
                        TenLop = p.Lop.TenLop
                    })
                    .ToList();
            }
        }

        public SinhVienDTO LaySinhVienTheoMa(string maSV)
        {
            using (var db = new QLSVDataContext())
            {
                return db.SinhViens
                    .Where(p => p.MaSV == maSV)
                    .Select(p => new SinhVienDTO
                    {
                        MaSV = p.MaSV,
                        HoTen = p.HoTen,
                        NgaySinh = p.NgaySinh,
                        GioiTinh = p.GioiTinh,
                        DiaChi = p.DiaChi,
                        Email = p.Email,
                        MaLop = p.MaLop,
                        TenLop = p.Lop.TenLop
                    })
                    .SingleOrDefault();
            }
        }

        public string ThemSinhVien(SinhVienDTO sv)
        {
            string loi = KiemTraHopLe(sv);
            if (loi != null) return loi;

            using (var db = new QLSVDataContext())
            {
                string ma = sv.MaSV.Trim();
                if (db.SinhViens.Any(p => p.MaSV == ma))
                    return "Mã sinh viên đã tồn tại";

                db.SinhViens.InsertOnSubmit(new SinhVien
                {
                    MaSV = ma,
                    HoTen = sv.HoTen.Trim(),
                    NgaySinh = sv.NgaySinh,
                    GioiTinh = sv.GioiTinh,
                    DiaChi = sv.DiaChi,
                    Email = sv.Email,
                    MaLop = sv.MaLop
                });
                db.SubmitChanges();
                return null;
            }
        }

        public string SuaSinhVien(SinhVienDTO sv)
        {
            string loi = KiemTraHopLe(sv);
            if (loi != null) return loi;

            using (var db = new QLSVDataContext())
            {
                SinhVien e = db.SinhViens.SingleOrDefault(p => p.MaSV == sv.MaSV);
                if (e == null) return "Không tìm thấy sinh viên";

                e.HoTen = sv.HoTen.Trim();
                e.NgaySinh = sv.NgaySinh;
                e.GioiTinh = sv.GioiTinh;
                e.DiaChi = sv.DiaChi;
                e.Email = sv.Email;
                e.MaLop = sv.MaLop;
                db.SubmitChanges();
                return null;
            }
        }

        public string XoaSinhVien(string maSV)
        {
            using (var db = new QLSVDataContext())
            {
                SinhVien e = db.SinhViens.SingleOrDefault(p => p.MaSV == maSV);
                if (e == null) return "Không tìm thấy sinh viên";

                if (db.DangKyHocPhans.Any(p => p.MaSV == maSV))
                    return "Sinh viên đã có đăng ký học phần, không thể xóa";
                if (db.NguoiDungs.Any(p => p.MaSV == maSV))
                    return "Sinh viên đang có tài khoản đăng nhập, không thể xóa";

                db.SinhViens.DeleteOnSubmit(e);
                db.SubmitChanges();
                return null;
            }
        }

        // ===== Hàm nội bộ =====
        private string KiemTraHopLe(SinhVienDTO sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV)) return "Chưa nhập mã sinh viên";
            if (string.IsNullOrWhiteSpace(sv.HoTen)) return "Chưa nhập họ tên";
            if (string.IsNullOrEmpty(sv.MaLop)) return "Chưa chọn lớp";
            if (sv.NgaySinh.HasValue && sv.NgaySinh.Value > System.DateTime.Today)
                return "Ngày sinh không được ở tương lai";
            if (!string.IsNullOrWhiteSpace(sv.Email) && !sv.Email.Contains("@"))
                return "Email không hợp lệ";
            return null;
        }
    }
}