using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }  
        public string MaPhong { get; set; }   
        public DateTime? TuNgay { get; set; } 
        public DateTime? ToiNgay { get; set; } 
        public float? TienPhong { get; set; }  
        public float? TienDien { get; set; } 
        public float? TienNuoc { get; set; }  
        public float? TienDichVu { get; set; } 
        public float? TongTien { get; set; }

        public HoaDonDTO(string maHoaDon, string maPhong, DateTime? tuNgay, DateTime? toiNgay,float? tienPhong, float? tienDien, float? tienNuoc, float? tienDichVu, float? tongTien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaPhong = maPhong;
            this.TuNgay = tuNgay;
            this.ToiNgay = toiNgay;
            this.TienPhong = tienPhong;
            this.TienDien = tienDien;
            this.TienNuoc = tienNuoc;
            this.TienDichVu = tienDichVu;
            this.TongTien = tongTien;
        }
        public HoaDonDTO() { }
    }
}
