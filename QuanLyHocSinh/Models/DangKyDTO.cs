// DangKyDTO.cs
using System;

namespace QLSV.Models
{
    public class DangKyDTO
    {
        public string MaLHP { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }
        public int? Thu { get; set; }
        public int? TietBD { get; set; }
        public int? SoTiet { get; set; }
        public DateTime NgayDK { get; set; }
        public double? DiemSo { get; set; }

        public string Lich
        {
            get
            {
                if (Thu == null || TietBD == null || SoTiet == null) return "";
                return "Thứ " + Thu + ", tiết " + TietBD + "-" + (TietBD + SoTiet - 1);
            }
        }
    }
}