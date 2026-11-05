using QLSV.Services;
using QuanLyHocSinh.Forms.HeThong;
using System;
using System.Windows.Forms;

namespace QLSV
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                    Application.Run(new frmMain());
            }
        }
    }
}