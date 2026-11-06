// Models\DangKyBaoCaoDTO.cs
using System;

namespace QLSV.Models
{
    public class DangKyBaoCaoDTO
    {
        public DateTime NgayDK { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string TenLop { get; set; }
        public string MaLHP { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }
    }
}