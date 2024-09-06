using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        

        DataProvider dp = new DataProvider();

        public bool Login(NguoiDungDTO nd)
        {
            string query = "SELECT * FROM NguoiDung WHERE TaiKhoan = '" + nd.TaiKhoan + "' AND MatKhau = '" + nd.MatKhau + "'";
            DataTable dt = dp.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                Session.CurrentUser = nd.TaiKhoan;
                
                return true;
            }
            return false;
        }

        public bool ChangePassword(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            string query = "UPDATE NguoiDung SET MatKhau = '" + matKhauMoi + "' WHERE TaiKhoan = '" + taiKhoan + "' AND MatKhau = '" + matKhauCu + "'";
            return dp.RunQuery(query);
            
        }
    }
}
