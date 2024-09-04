using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=HP;Initial Catalog=QLPhongTroCaoCap;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(strcon);
            return con;
        }
    }

    public class DataAccess
    {
        public static string LoginDTO(NguoiDungDTO nguoidung)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string strquery = "SELECT * FROM NguoiDung WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", nguoidung.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", nguoidung.MatKhau);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) 
            {
                while (reader.Read()) 
                { 
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            } 
            return user;
        }

        public bool ChangePasswordDTO(string taiKhoan, string matKhauCu, string matKhauMoi)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string strquery = "UPDATE NguoiDung SET MatKhau = @MatKhauMoi WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhauCu";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
            cmd.Parameters.AddWithValue("@MatKhauCu", matKhauCu);
            cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
    }
}
