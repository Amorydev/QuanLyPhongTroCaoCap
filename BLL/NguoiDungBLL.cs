using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class Session
    {
        public static string CurrentUser { get; set; }
    }

    public class NguoiDungBLL
    {
        NguoiDungAccess ndAccess = new NguoiDungAccess();
        public string Login(NguoiDungDTO nguoidung)
        {
            string info = ndAccess.Login(nguoidung);
            return info;
        }

        public bool ChangePassword(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            return ndAccess.ChangePasswordDTO(taiKhoan, matKhauCu, matKhauMoi);
        }
    }
}
