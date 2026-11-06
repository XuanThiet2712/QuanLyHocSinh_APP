using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Models
{
    public class DiemDTO
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string TenLop { get; set; }
        public double? DiemSo { get; set; }   // null = chưa có điểm
    }
}
