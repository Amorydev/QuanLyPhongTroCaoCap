using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class NguoiDungAccess:DataAccess
    {
        public string Login(NguoiDungDTO nguoidung)
        {
            string info = LoginDTO(nguoidung);
            return info;
        }

        public bool ChangePassword(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            return ChangePasswordDTO(taiKhoan, matKhauCu, matKhauMoi);
        }

    }
}
