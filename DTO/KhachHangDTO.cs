using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string QueQuan { get; set; }
        public string NgheNghiep { get; set; }

        public KhachHangDTO()
        {
        }
        public KhachHangDTO(string makh, string hoten, string cccd, DateTime ngaysinh, string gioitinh, string dienthoai, string quequan, string nghenghiep)
        {
            this.MaKhachHang = makh;
            this.HoTen = hoten;
            this.CCCD = cccd;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.DienThoai = dienthoai;
            this.QueQuan = quequan;
            this.NgheNghiep = nghenghiep;
        }
    }

    
  
}
