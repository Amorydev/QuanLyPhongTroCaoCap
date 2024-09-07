using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        public string MaPhong {  get; set; }
        public string TenPhong {  get; set; }
        public string TrangThai {  get; set; }
        public string LoaiPhong {  get; set; }
        public float GiaPhong {  get; set; }
        public string NoiThat {  get; set; }
        public string MaTang { get; set; }

        public PhongDTO()
        {
        }
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
