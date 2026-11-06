using DevExpress.XtraEditors.Filtering.Templates;
using QLSV.Models;
using QuanLyHocSinh;
using QuanLyHocSinh.Models;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System;
namespace QLSV.Services
{
    public class EnrollService
    {
        public const int TIN_CHI_TOI_DA = 24;

        // ===== Truy vấn =====
        public List<HocKyDTO> LayDanhSachHocKy()
        {
            using (var db = new QLSVDataContext())
            {
                // Nếu db.HocKies báo đỏ, gõ "db." để xem tên đúng
                return db.HocKies
                    .OrderByDescending(p => p.TuNgay)
                    .Select(p => new HocKyDTO { MaHocKy = p.MaHocKy, TenHocKy = p.TenHocKy })
                    .ToList();
            }
        }

        public List<LopHocPhanDTO> LayLopHocPhan(string maHocKy)
        {
            using (var db = new QLSVDataContext())
            {
                return db.LopHocPhans
                    .Where(p => p.MaHocKy == maHocKy)
                    .OrderBy(p => p.MaLHP)
                    .Select(p => new LopHocPhanDTO
                    {
                        MaLHP = p.MaLHP,
                        TenMon = p.MonHoc.TenMon,
                        SoTinChi = p.MonHoc.SoTinChi,
                        TenGV = p.GiangVien.HoTen,
                        Thu = p.Thu,
                        TietBD = p.TietBD,
                        SoTiet = p.SoTiet,
                        SiSoToiDa = p.SiSoToiDa,
                        DaDangKy = p.DangKyHocPhans.Count()
                    })
                    .ToList();
            }
        }

        public List<DangKyDTO> LayHocPhanDaDangKy(string maSV, string maHocKy)
        {
            using (var db = new QLSVDataContext())
            {
                return db.DangKyHocPhans
                    .Where(p => p.MaSV == maSV && p.LopHocPhan.MaHocKy == maHocKy)
                    .OrderBy(p => p.NgayDK)
                    .Select(p => new DangKyDTO
                    {
                        MaLHP = p.MaLHP,
                        TenMon = p.LopHocPhan.MonHoc.TenMon,
                        SoTinChi = p.LopHocPhan.MonHoc.SoTinChi,
                        Thu = p.LopHocPhan.Thu,
                        TietBD = p.LopHocPhan.TietBD,
                        SoTiet = p.LopHocPhan.SoTiet,
                        NgayDK = p.NgayDK,
                        DiemSo = p.DiemSo
                    })
                    .ToList();
            }
        }

        public int TinhTongTinChi(string maSV, string maHocKy)
        {
            using (var db = new QLSVDataContext())
            {
                return db.DangKyHocPhans
                    .Where(p => p.MaSV == maSV && p.LopHocPhan.MaHocKy == maHocKy)
                    .Sum(p => (int?)p.LopHocPhan.MonHoc.SoTinChi) ?? 0;
            }
        }

        // ===== Nghiệp vụ chính =====
        // Trả về null nếu thành công, ngược lại trả nội dung lỗi
        public string DangKyNhieu(string maSV, List<string> dsMaLHP)
        {
            if (dsMaLHP == null || dsMaLHP.Count == 0)
                return "Chưa chọn lớp học phần nào";

            // Nhờ CatalogService (người B) kiểm tra sinh viên có tồn tại không.
            // Làm TRƯỚC khi mở transaction để tránh hai kết nối trong một transaction.
            if (new CatalogService().LaySinhVienTheoMa(maSV) == null)
                return "Không tìm thấy sinh viên " + maSV;

            using (var scope = new TransactionScope())
            using (var db = new QLSVDataContext())
            {
                db.Connection.Open();   // dùng đúng MỘT kết nối cho cả giao dịch

                foreach (string maLHP in dsMaLHP)
                {
                    string loi = KiemTraVaDangKy(db, maSV, maLHP);
                    if (loi != null)
                        return loi;     // thoát mà chưa Complete() => rollback tất cả
                }

                scope.Complete();       // chỉ khi đi tới đây thì mới lưu thật
                return null;
            }
        }

        // Kiểm tra 6 quy tắc rồi ghi một đăng ký
        private string KiemTraVaDangKy(QLSVDataContext db, string maSV, string maLHP)
        {
            // Quy tắc 1: lớp phải tồn tại
            LopHocPhan lhp = db.LopHocPhans.SingleOrDefault(p => p.MaLHP == maLHP);
            if (lhp == null) return "Không tìm thấy lớp " + maLHP;

            // Quy tắc 2: chưa đăng ký lớp này
            if (db.DangKyHocPhans.Any(p => p.MaSV == maSV && p.MaLHP == maLHP))
                return "Bạn đã đăng ký lớp " + maLHP;

            // Quy tắc 3: còn chỗ
            int daDangKy = db.DangKyHocPhans.Count(p => p.MaLHP == maLHP);
            if (daDangKy >= lhp.SiSoToiDa)
                return "Lớp " + maLHP + " đã hết chỗ (" + daDangKy + "/" + lhp.SiSoToiDa + ")";

            // Quy tắc 4: không đăng ký hai lớp của cùng một môn trong một học kỳ
            if (db.DangKyHocPhans.Any(p => p.MaSV == maSV
                    && p.LopHocPhan.MaMon == lhp.MaMon
                    && p.LopHocPhan.MaHocKy == lhp.MaHocKy))
                return "Môn " + lhp.MaMon + " đã được đăng ký ở một lớp khác trong học kỳ này";

            // Quy tắc 5: không trùng lịch học
            if (lhp.Thu != null && lhp.TietBD != null && lhp.SoTiet != null)
            {
                var lichDaCo = db.DangKyHocPhans
                    .Where(p => p.MaSV == maSV && p.LopHocPhan.MaHocKy == lhp.MaHocKy
                                && p.LopHocPhan.Thu == lhp.Thu)
                    .Select(p => new { p.MaLHP, p.LopHocPhan.TietBD, p.LopHocPhan.SoTiet })
                    .ToList();

                foreach (var c in lichDaCo)
                {
                    if (c.TietBD == null || c.SoTiet == null) continue;
                    bool trung = lhp.TietBD < c.TietBD + c.SoTiet
                              && c.TietBD < lhp.TietBD + lhp.SoTiet;
                    if (trung)
                        return "Lớp " + maLHP + " trùng lịch với lớp " + c.MaLHP;
                }
            }

            // Quy tắc 6: tổng tín chỉ trong học kỳ không vượt mức tối đa
            int tongTC = db.DangKyHocPhans
                .Where(p => p.MaSV == maSV && p.LopHocPhan.MaHocKy == lhp.MaHocKy)
                .Sum(p => (int?)p.LopHocPhan.MonHoc.SoTinChi) ?? 0;
            int tcMoi = db.MonHocs.Single(p => p.MaMon == lhp.MaMon).SoTinChi;
            if (tongTC + tcMoi > TIN_CHI_TOI_DA)
                return "Vượt quá " + TIN_CHI_TOI_DA + " tín chỉ (hiện " + tongTC + ", thêm " + tcMoi + ")";

            // Hợp lệ: ghi
            db.DangKyHocPhans.InsertOnSubmit(new DangKyHocPhan
            {
                MaSV = maSV,
                MaLHP = maLHP,
                NgayDK = DateTime.Now
            });
            db.SubmitChanges();
            return null;
        }

        public string HuyDangKy(string maSV, string maLHP)
        {
            using (var db = new QLSVDataContext())
            {
                DangKyHocPhan dk = db.DangKyHocPhans
                    .SingleOrDefault(p => p.MaSV == maSV && p.MaLHP == maLHP);
                if (dk == null) return "Không tìm thấy đăng ký";
                if (dk.DiemSo != null) return "Lớp đã có điểm, không thể hủy đăng ký";

                db.DangKyHocPhans.DeleteOnSubmit(dk);
                db.SubmitChanges();
                return null;
            }
        }

        public List<DangKyBaoCaoDTO> LayDangKyTheoKhoang(DateTime tuNgay, DateTime denNgay, string maLop)
        {
            DateTime tu = tuNgay.Date;
            DateTime den = denNgay.Date.AddDays(1);   // lấy đến hết ngày cuối

            using (var db = new QLSVDataContext())
            {
                var q = db.DangKyHocPhans.Where(p => p.NgayDK >= tu && p.NgayDK < den);

                if (!string.IsNullOrEmpty(maLop))
                    q = q.Where(p => p.SinhVien.MaLop == maLop);

                return q.OrderBy(p => p.NgayDK).ThenBy(p => p.MaSV)
                    .Select(p => new DangKyBaoCaoDTO
                    {
                        NgayDK = p.NgayDK,
                        MaSV = p.MaSV,
                        HoTen = p.SinhVien.HoTen,
                        TenLop = p.SinhVien.Lop.TenLop,
                        MaLHP = p.MaLHP,
                        TenMon = p.LopHocPhan.MonHoc.TenMon,
                        SoTinChi = p.LopHocPhan.MonHoc.SoTinChi
                    })
                    .ToList();
            }
        }
    }
}