using System;
using System.Windows.Forms;
using QLSV.Services;

namespace QLSV
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //// TẠM THỜI: tạo tài khoản mẫu, chạy xong thì xóa 4 dòng này
            //var auth = new AuthService();
            //auth.TaoTaiKhoan("admin", "Admin@123", "ADMIN");
            //auth.TaoTaiKhoan("gv01", "Gv@12345", "GIANGVIEN");
            //auth.TaoTaiKhoan("gvu01", "Gvu@12345", "GIAOVU");

            Application.Run(new Form());   // tạm: form rỗng, ta thay ở Bước 9
        }
    }
}