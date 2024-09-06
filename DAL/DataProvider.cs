using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using DTO;
=======
>>>>>>> 0305310ae21310968884c9c6e5d19b3ca8789671

namespace DAL
{
    public class DataProvider
    {
        private SqlDataAdapter da;
        private SqlConnection sqlconn;
        private DataTable dt;
        // XD ham ket noi du lieu
        private void Connected()
        {
<<<<<<< HEAD
            string strconn = "Data Source=THUAN\\THUAN;Initial Catalog=QLPhongTroCaoCap;Integrated Security=True";
=======
            string strconn = "Data Source=DESKTOP-2M3CSSN\\MSSQLSERVER02;Initial Catalog=QLPhongTroCaoCap;Integrated Security=True;Encrypt=False";
>>>>>>> 0305310ae21310968884c9c6e5d19b3ca8789671
            try
            {
                if (sqlconn == null)
                {
                    sqlconn = new SqlConnection(strconn);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //XD ham do du lieu DataTAble
        public DataTable GetDataTable(string strquery)
        {
            Connected();
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
            da = new SqlDataAdapter(strquery, sqlconn);
            dt = new DataTable();
            da.Fill(dt);
            if (sqlconn.State == ConnectionState.Open)
            {
                sqlconn.Close();
            }

            return dt;
        }

        //XD ham chay query
<<<<<<< HEAD
        public bool RunQuery(string strquery)
        {
            int check = 0;
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                }

                SqlCommand cmd = new SqlCommand(strquery, sqlconn);
                check = cmd.ExecuteNonQuery();

                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (check > 0)
                return true;

            return false;
=======
        public bool RunQuery(string strquery, params SqlParameter[] parameters)
        {
            using (var cmd = new SqlCommand(strquery, sqlconn))
            {
                cmd.Parameters.AddRange(parameters);
                sqlconn.Open();
                int check = cmd.ExecuteNonQuery();
                sqlconn.Close();
                return check > 0;
            }
>>>>>>> 0305310ae21310968884c9c6e5d19b3ca8789671
        }
        public bool CheckField(string TableName, string FieldName, string value)
        {
            string strquery = "select * from " + TableName + " where " + FieldName + "='" + value + "'";
            GetDataTable(strquery);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
