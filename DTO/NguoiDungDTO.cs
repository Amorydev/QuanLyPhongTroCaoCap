using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }

        public NguoiDungDTO()
        {

        }

        public NguoiDungDTO(string taikhoan, string matkhau, string hoten)
        {
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
            this.HoTen = hoten;
        }
    }
}
