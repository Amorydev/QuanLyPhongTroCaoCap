using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class KhachHangBLL 
    {
        DataProvider dp = new DataProvider();

        //public List<KhachHangDTO> GetKhachHang()
        //{
        //    string strquery = "SELECT * FROM KhachHang";
        //    List<KhachHangDTO> list = new List<KhachHangDTO>();
        //    foreach (DataRow dr in dp.GetDataTable(strquery).Rows)
        //    {
        //        list.Add(new KhachHangDTO(dr["MaKhachHang"].ToString(), dr["HoTen"].ToString(), dr["CCCD"].ToString(), Convert.ToDateTime(dr["NgaySinh"]), dr["GioiTinh"].ToString(), dr["DienThoai"].ToString(), dr["QueQuan"].ToString(), dr["NgheNghiep"].ToString()));
        //    }
        //    return list;
        //}

        public DataTable GetDataKhachHang()
        {
            string strquery = "SELECT * FROM KhachHang";
            return dp.GetDataTable(strquery);
        }

        public void AddKhachHang(KhachHangDTO kh)
        {
            string strquery = $"INSERT INTO KhachHang VALUES ('{kh.MaKhachHang}', N'{kh.HoTen}', '{kh.CCCD}', '{kh.NgaySinh}', N'{kh.GioiTinh}', '{kh.DienThoai}', N'{kh.QueQuan}', N'{kh.NgheNghiep}')";
            if (dp.RunQuery(strquery))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }

        public void UpdateKhachHang(KhachHangDTO kh)
        { 
            string strquery = $"UPDATE KhachHang SET HoTen = N'{kh.HoTen}', CCCD = '{kh.CCCD}', NgaySinh = '{kh.NgaySinh}', GioiTinh = N'{kh.GioiTinh}', DienThoai = '{kh.DienThoai}', QueQuan = N'{kh.QueQuan}', NgheNghiep = N'{kh.NgheNghiep}' WHERE MaKhachHang = '{kh.MaKhachHang}'";
            if (dp.RunQuery(strquery))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        public void DeleteKhachHang(string makh)
        {
            string strquery = $"DELETE FROM KhachHang WHERE MaKhachHang = '{makh}'";
            if (dp.RunQuery(strquery))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        public DataTable SearchKhachHang(string makh)
        {
            string strquery = $"SELECT * FROM KhachHang WHERE MaKhachHang = '{makh}'";
            return dp.GetDataTable(strquery);
        }

        public bool CheckFieldData(string makh)
        {
            if (dp.CheckField("KhachHang", "MaKhachHang", makh))
            {
                return true;
            }
            return false;
        }

        public bool CheckSave(KhachHangDTO kh)
        {
            //Xem ma co trong CSDL
            if (CheckFieldData(kh.MaKhachHang))
            {
                MessageBox.Show("Mã này đã tồn tại trong CSDL", "Thông báo");
                return false;
            }
            if (kh.MaKhachHang.Equals(""))
            {
                MessageBox.Show("Mã khách hàng không để trống", "Thông báo");
                return false;
            }
            if (kh.MaKhachHang.Equals(""))
            {
                MessageBox.Show("Tên khách hàng không để trống", "Thông báo");
                return false;
            }

            return true;
        }



    }
}
