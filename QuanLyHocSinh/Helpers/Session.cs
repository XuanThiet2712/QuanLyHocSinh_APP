using System.Collections.Generic;

namespace QLSV.Helpers
{
    public static class Session
    {
        public static string TenDangNhap { get; set; }
        public static string MaNhom { get; set; }
        public static HashSet<string> DanhSachQuyen { get; set; } = new HashSet<string>();

        public static bool CoQuyen(string maChucNang)
        {
            return DanhSachQuyen.Contains(maChucNang);
        }

        public static void Xoa()
        {
            TenDangNhap = null;
            MaNhom = null;
            DanhSachQuyen.Clear();
        }
    }
}