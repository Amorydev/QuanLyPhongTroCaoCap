using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongDTO
    {
        public string MaHopDong { get; set; }
        public string MaKhachHang { get; set; }
        public string MaPhong { get; set; }
        public float? GiaPhong { get; set; }
        public float? TienDatCoc { get; set; }
        public DateTime? NgayThue { get; set; }
        public DateTime NgayTraPhong { get; set; }

       
        public HopDongDTO(string maHopDong, string maKhachHang, string maPhong, float? giaPhong, float? tienDatCoc, DateTime? ngayThue, DateTime ngayTraPhong)
        {
            MaHopDong = maHopDong;
            MaKhachHang = maKhachHang;
            MaPhong = maPhong;
            GiaPhong = giaPhong;
            TienDatCoc = tienDatCoc;
            NgayThue = ngayThue;
            NgayTraPhong = ngayTraPhong;
        }

       
        public HopDongDTO()
        {
        }
    }
}
