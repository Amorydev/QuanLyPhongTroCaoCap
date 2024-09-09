using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ThietBiBLL
    {
        DataProvider dp = new DataProvider();

        public DataTable GetDataThietBiByTang(string mt)
        {
            string strquery = $"SELECT * FROM ThietBi WHERE MaTang = '{mt}'";
            return dp.GetDataTable(strquery);
        }

        public void AddThietBi(ThietBiDTO tb)
        {
            string strquery = $"INSERT INTO ThietBi VALUES ('{tb.MaThietBi}', N'{tb.TenThietBi}', '{tb.SoLuong}', '{tb.NgayMua}', '{tb.NgayBaoDuong}', N'{tb.TrangThai}', '{tb.TienMua}', '{tb.TienBaoDuong}', '{tb.MaTang}')";
            if (dp.RunQuery(strquery))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }

        public void UpdateThietBi(ThietBiDTO tb)
        {
            string strquery = $"UPDATE ThietBi SET TenThietBi = N'{tb.TenThietBi}', SoLuong = '{tb.SoLuong}', NgayMua = '{tb.NgayMua}', NgayBaoDuong = '{tb.NgayBaoDuong}', TrangThai = N'{tb.TrangThai}', TienMua = '{tb.TienMua}', TienBaoDuong = '{tb.TienBaoDuong}', MaTang = '{tb.MaTang}' WHERE MaThietBi = '{tb.MaThietBi}'";
            if (dp.RunQuery(strquery))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        public void DeleteThietBi(string matb)
        {
            string strquery = $"DELETE FROM ThietBi WHERE MaThietBi = '{matb}'";
            if (dp.RunQuery(strquery))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        public bool CheckFieldData(string mtb)
        {
            if (dp.CheckField("ThietBi", "MaThietBi", mtb))
            {
                return true;
            }
            return false;
        }

        public bool CheckSave(ThietBiDTO tb)
        {
            //Xem ma co trong CSDL
            if (CheckFieldData(tb.MaThietBi))
            {
                MessageBox.Show("Mã này đã tồn tại trong CSDL", "Thông báo");
                return false;
            }
            if (tb.MaThietBi.Equals(""))
            {
                MessageBox.Show("Mã thiết bị không để trống", "Thông báo");
                return false;
            }
            if (tb.TenThietBi.Equals(""))
            {
                MessageBox.Show("Tên thiết bị không để trống", "Thông báo");
                return false;
            }

            return true;
        }

    }
}
