using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Models
{
    public class LopHocPhanDTO
    {
        public string MaLHP { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }
        public string TenGV { get; set; }
        public int? Thu { get; set; }
        public int? TietBD { get; set; }
        public int? SoTiet { get; set; }
        public int SiSoToiDa { get; set; }
        public int DaDangKy { get; set; }

        // Thuộc tính tính toán: chỉ để hiển thị lên lưới
        public string Lich
        {
            get
            {
                if (Thu == null || TietBD == null || SoTiet == null) return "";
                return "Thứ " + Thu + ", tiết " + TietBD + "-" + (TietBD + SoTiet - 1);
            }
        }
        public string SiSo { get { return DaDangKy + "/" + SiSoToiDa; } }
    }
}
