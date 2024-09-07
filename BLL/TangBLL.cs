using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BLL
{
   
    public class TangBLL
    {
        private DataProvider dataProvider = new DataProvider();

        public List<TangDTO> GetMaTang()
        {
            List<TangDTO> maTangList = new List<TangDTO>();
            string query = "SELECT MaTang, TenTang FROM Tang"; 
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
    }
}
