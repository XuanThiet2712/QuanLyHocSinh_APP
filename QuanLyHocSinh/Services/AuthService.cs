using System.Collections.Generic;
using System.Linq;
using QLSV.Helpers;

namespace QLSV.Services
{
    public class AuthService
    {
        // Tạo tài khoản mới. Trả false nếu tên đã tồn tại.
        public bool TaoTaiKhoan(string user, string matKhau, string maNhom)
        {
            using (var db = new QLSVDataContext())
            {
                if (db.NguoiDungs.Any(p => p.TenDangNhap == user)) return false;

                string salt = PasswordHelper.TaoSalt();
                db.NguoiDungs.InsertOnSubmit(new NguoiDung
                {
                    TenDangNhap = user,
                    Salt = salt,
                    MatKhauHash = PasswordHelper.BamMatKhau(matKhau, salt),
                    MaNhom = maNhom,
                    HoatDong = true
                });
                db.SubmitChanges();
                return true;
            }
        }

        // Kiểm tra đăng nhập, nếu đúng thì nạp Session
        public bool DangNhap(string user, string matKhau)
        {
            using (var db = new QLSVDataContext())
            {
                NguoiDung nd = db.NguoiDungs
                    .SingleOrDefault(p => p.TenDangNhap == user && p.HoatDong);
                if (nd == null) return false;

                if (!PasswordHelper.KiemTra(matKhau, nd.Salt, nd.MatKhauHash)) return false;

                Session.TenDangNhap = nd.TenDangNhap;
                Session.MaNhom = nd.MaNhom;
                Session.DanhSachQuyen = new HashSet<string>(
                    db.PhanQuyens.Where(p => p.MaNhom == nd.MaNhom)
                                 .Select(p => p.MaChucNang));
                return true;
            }
        }

        public bool DoiMatKhau(string user, string matKhauCu, string matKhauMoi)
        {
            using (var db = new QLSVDataContext())
            {
                NguoiDung nd = db.NguoiDungs.SingleOrDefault(p => p.TenDangNhap == user);
                if (nd == null) return false;
                if (!PasswordHelper.KiemTra(matKhauCu, nd.Salt, nd.MatKhauHash)) return false;

                nd.Salt = PasswordHelper.TaoSalt();
                nd.MatKhauHash = PasswordHelper.BamMatKhau(matKhauMoi, nd.Salt);
                db.SubmitChanges();
                return true;
            }
        }
    }
}