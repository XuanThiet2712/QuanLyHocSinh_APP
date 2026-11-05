using System;
using System.Security.Cryptography;
using System.Text;

namespace QLSV.Helpers
{
    public static class PasswordHelper
    {
        // Tạo chuỗi ngẫu nhiên 16 byte, mỗi người dùng một chuỗi riêng
        public static string TaoSalt()
        {
            byte[] b = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(b);
            }
            return Convert.ToBase64String(b);
        }

        // Băm (salt + mật khẩu) bằng SHA-256
        public static string BamMatKhau(string matKhau, string salt)
        {
            using (var sha = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(salt + matKhau);
                return Convert.ToBase64String(sha.ComputeHash(data));
            }
        }

        public static bool KiemTra(string matKhau, string salt, string hashDaLuu)
        {
            return BamMatKhau(matKhau, salt) == hashDaLuu;
        }
    }
}