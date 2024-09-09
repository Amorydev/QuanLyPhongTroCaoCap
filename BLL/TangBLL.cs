using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace BLL
{
   
    public class TangBLL
    {
        DataProvider dataProvider = new DataProvider();

        public List<TangDTO> GetDataTang()
        {
            List<TangDTO> maTangList = new List<TangDTO>();
            string query = "SELECT * FROM Tang"; 
            DataTable dataTable = dataProvider.GetDataTable(query);
            foreach (DataRow row in dataTable.Rows)
            {
                TangDTO maTang = new TangDTO
                {
                    MaTang = row["MaTang"].ToString(),
                    TenTang = row["TenTang"].ToString()
                };
                maTangList.Add(maTang);
            }

            return maTangList;
        }

        public void AddTang(TangDTO tang)
        {
            string strquery = $"INSERT INTO Tang (MaTang, TenTang) VALUES ('{tang.MaTang}', N'{tang.TenTang}')";
            if (dataProvider.RunQuery(strquery))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }

        public void UpdateTang(TangDTO tang)
        {
            string strquery = $"UPDATE Tang SET TenTang = N'{tang.TenTang}' WHERE MaTang = '{tang.MaTang}'";
            if (dataProvider.RunQuery(strquery))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        public void DeleteTang(string maTang)
        {
            string strquery = $"DELETE FROM Tang WHERE MaTang = '{maTang}'";
            if (dataProvider.RunQuery(strquery))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        public bool CheckFieldData(string mt)
        {
            if (dataProvider.CheckField("Tang", "MaTang", mt))
            {
                return true;
            }
            return false;
        }

        public bool CheckSave(TangDTO t)
        {
            //Xem ma co trong CSDL
            if (CheckFieldData(t.MaTang))
            {
                MessageBox.Show("Mã này đã tồn tại trong CSDL", "Thông báo");
                return false;
            }
            if (t.MaTang.Equals(""))
            {
                MessageBox.Show("Mã tầng không để trống", "Thông báo");
                return false;
            }
            if (t.TenTang.Equals(""))
            {
                MessageBox.Show("Tên tầng không để trống", "Thông báo");
                return false;
            }

            return true;
        }
    }
}
