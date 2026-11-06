namespace QLSV.Models
{
    public class BangDiemDTO
    {
        public string MaLHP { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }
        public string TenHocKy { get; set; }
        public double? DiemSo { get; set; }

        // Hai thuộc tính dưới dùng để in, tính sẵn ở service
        public string DiemHienThi { get; set; }
        public string XepLoai { get; set; }
    }
}