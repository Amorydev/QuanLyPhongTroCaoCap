using System;

namespace DTO
{
    public class PhongDTO
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TrangThai { get; set; }
        public string LoaiPhong { get; set; }
        public float GiaPhong { get; set; }
        public string NoiThat { get; set; }
        public string MaTang { get; set; }

        // Constructor không tham số
        public PhongDTO()
        {
        }

        // Constructor với tham số
        public PhongDTO(string maPhong, string tenPhong, string trangThai, string loaiPhong, float giaPhong, string noiThat, string maTang)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.TrangThai = trangThai;
            this.LoaiPhong = loaiPhong;
            this.GiaPhong = giaPhong;
            this.NoiThat = noiThat;
            this.MaTang = maTang;
        }
    }
}
