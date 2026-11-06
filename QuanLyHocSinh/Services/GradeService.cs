using QuanLyHocSinh.Models;
using QuanLyHocSinh;
using QuanLyHocSinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHocSinh.Services
{
    public class GradeService
    {
        // ===== Nhập điểm =====
        public List<DiemDTO> LayDanhSachDiem(string maLHP)
        {
            using (var db = new QLSVDataContext())
            {
                return db.DangKyHocPhans
                    .Where(p => p.MaLHP == maLHP)
                    .OrderBy(p => p.MaSV)
                    .Select(p => new DiemDTO
                    {
                        MaSV = p.MaSV,
                        HoTen = p.SinhVien.HoTen,
                        TenLop = p.SinhVien.Lop.TenLop,
                        DiemSo = p.DiemSo
                    })
                    .ToList();
            }
        }

        // Lưu điểm cả lớp một lần. Trả null nếu thành công.
        public string LuuDiem(string maLHP, List<DiemDTO> ds)
        {
            if (ds == null) return "Không có dữ liệu để lưu";

            foreach (DiemDTO d in ds)
            {
                if (d.DiemSo.HasValue && (d.DiemSo < 0 || d.DiemSo > 10))
                    return "Điểm của " + d.MaSV + " phải nằm trong khoảng 0 đến 10";
            }

            using (var db = new QLSVDataContext())
            {
                List<DangKyHocPhan> dsDK = db.DangKyHocPhans
                    .Where(p => p.MaLHP == maLHP).ToList();

                foreach (DiemDTO d in ds)
                {
                    DangKyHocPhan dk = dsDK.SingleOrDefault(p => p.MaSV == d.MaSV);
                    if (dk == null) continue;
                    dk.DiemSo = d.DiemSo.HasValue ? Math.Round(d.DiemSo.Value, 2) : (double?)null;
                }

                db.SubmitChanges();   // một lần cho cả lớp, tự chạy trong một giao dịch
                return null;
            }
        }

        // ===== Tính toán =====
        // GPA thang 10 có trọng số tín chỉ. Chưa có điểm nào thì trả 0.
        public double TinhGPA(string maSV)
        {
            using (var db = new QLSVDataContext())
            {
                var ds = db.DangKyHocPhans
                    .Where(p => p.MaSV == maSV && p.DiemSo != null)
                    .Select(p => new { Diem = p.DiemSo.Value, TC = p.LopHocPhan.MonHoc.SoTinChi })
                    .ToList();

                if (ds.Count == 0) return 0;
                return Math.Round(ds.Sum(x => x.Diem * x.TC) / ds.Sum(x => x.TC), 2);
            }
        }

        public static string XepLoai(double diem)
        {
            if (diem >= 8) return "Giỏi";
            if (diem >= 6.5) return "Khá";
            if (diem >= 5) return "Trung bình";
            return "Yếu";
        }

        // ===== Dữ liệu cho biểu đồ =====

        // 1. Tỷ lệ xếp loại (Doughnut/Pie)
        public List<ThongKeDTO> PhoXepLoai()
        {
            using (var db = new QLSVDataContext())
            {
                List<double> diem = db.DangKyHocPhans
                    .Where(p => p.DiemSo != null)
                    .Select(p => p.DiemSo.Value)
                    .ToList();

                string[] thuTu = { "Giỏi", "Khá", "Trung bình", "Yếu" };
                return thuTu
                    .Select(t => new ThongKeDTO
                    {
                        Nhan = t,
                        GiaTri = diem.Count(d => XepLoai(d) == t)
                    })
                    .ToList();
            }
        }

        // 2. Điểm trung bình theo lớp (Column)
        public List<ThongKeDTO> DiemTrungBinhTheoLop()
        {
            using (var db = new QLSVDataContext())
            {
                return db.DangKyHocPhans
                    .Where(p => p.DiemSo != null)
                    .GroupBy(p => p.SinhVien.Lop.TenLop)
                    .Select(g => new ThongKeDTO
                    {
                        Nhan = g.Key,
                        GiaTri = g.Average(x => x.DiemSo.Value)
                    })
                    .OrderBy(x => x.Nhan)
                    .ToList();
            }
        }

        // 3. Top n sinh viên có GPA cao nhất (Bar)
        public List<ThongKeDTO> TopSinhVien(int n)
        {
            using (var db = new QLSVDataContext())
            {
                var thoGio = db.DangKyHocPhans
                    .Where(p => p.DiemSo != null)
                    .Select(p => new
                    {
                        p.MaSV,
                        p.SinhVien.HoTen,
                        Diem = p.DiemSo.Value,
                        TC = p.LopHocPhan.MonHoc.SoTinChi
                    })
                    .ToList();   // lấy về bộ nhớ rồi mới tính GPA

                return thoGio
                    .GroupBy(x => new { x.MaSV, x.HoTen })
                    .Select(g => new ThongKeDTO
                    {
                        Nhan = g.Key.HoTen,
                        GiaTri = Math.Round(g.Sum(x => x.Diem * x.TC) / g.Sum(x => x.TC), 2)
                    })
                    .OrderByDescending(x => x.GiaTri)
                    .Take(n)
                    .ToList();
            }
        }

        // 4. Số lượt đăng ký theo ngày (Line)
        public List<ThongKeDTO> DangKyTheoNgay()
        {
            using (var db = new QLSVDataContext())
            {
                List<DateTime> ngay = db.DangKyHocPhans.Select(p => p.NgayDK).ToList();

                return ngay
                    .GroupBy(d => d.Date)
                    .OrderBy(g => g.Key)
                    .Select(g => new ThongKeDTO { Nhan = g.Key.ToString("dd/MM"), GiaTri = g.Count() })
                    .ToList();
            }
        }

        // 5. Phổ điểm: số điểm rơi vào từng khoảng 0-1, 1-2, ..., 9-10 (Area/Column)
        public List<ThongKeDTO> PhoDiem()
        {
            using (var db = new QLSVDataContext())
            {
                List<double> diem = db.DangKyHocPhans
                    .Where(p => p.DiemSo != null)
                    .Select(p => p.DiemSo.Value)
                    .ToList();

                var kq = new List<ThongKeDTO>();
                for (int i = 0; i < 10; i++)
                {
                    int tu = i, den = i + 1;
                    int dem = diem.Count(d => d >= tu && (tu == 9 ? d <= den : d < den));
                    kq.Add(new ThongKeDTO { Nhan = tu + "-" + den, GiaTri = dem });
                }
                return kq;
            }
        }

        // 6. Điểm trung bình theo môn (Radar)
        public List<ThongKeDTO> DiemTrungBinhTheoMon()
        {
            using (var db = new QLSVDataContext())
            {
                return db.DangKyHocPhans
                    .Where(p => p.DiemSo != null)
                    .GroupBy(p => p.LopHocPhan.MonHoc.TenMon)
                    .Select(g => new ThongKeDTO
                    {
                        Nhan = g.Key,
                        GiaTri = g.Average(x => x.DiemSo.Value)
                    })
                    .OrderBy(x => x.Nhan)
                    .ToList();
            }
        }
    }
}