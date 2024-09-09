using DAL;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PhongBLL
    {
        private readonly DataProvider dp = new DataProvider();

        public DataTable GetDataPhong()
        {
            string strquery = "SELECT * FROM Phong";
            return dp.GetDataTable(strquery);
        }
        

        public DataTable GetDataPhongTheoTang(string maTang)
        {
            string strquery = $"SELECT * FROM Phong WHERE MaTang = '{maTang}'";
            return dp.GetDataTable(strquery);

        }
        public void AddPhong(PhongDTO phongDTO)
        {

            string sqlquery = $"INSERT INTO Phong VALUES ('{phongDTO.MaPhong}', N'{phongDTO.TenPhong}', N'{phongDTO.TrangThai}', N'{phongDTO.LoaiPhong}', '{phongDTO.GiaPhong}', N'{phongDTO.NoiThat}', '{phongDTO.MaTang}')";
            if (dp.RunQuery(sqlquery))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm phòng", "Thông báo lỗi");
            }
        }

        public void UpdatePhong(PhongDTO pb)
        {

            string strquery = $"UPDATE Phong SET TenPhong = N'{pb.TenPhong}', TrangThai = N'{pb.TrangThai}', LoaiPhong = N'{pb.LoaiPhong}', GiaPhong = '{pb.GiaPhong}', NoiThat = N'{pb.NoiThat}', MaTang = '{pb.MaTang}' WHERE MaPhong = '{pb.MaPhong}'";
            if (dp.RunQuery(strquery))

            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật phòng", "Thông báo lỗi");
            }
        }

        public void DeletePhong(PhongDTO pb)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string strquery = $"DELETE FROM Phong WHERE MaPhong = '{pb.MaPhong}'";
               if (dp.RunQuery(strquery)) 
               {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                     MessageBox.Show("Lỗi khi xóa phòng", "Thông báo lỗi");
               }

            }
        }

        public bool CheckFieldData(string map)
        {
            return dp.CheckField("Phong", "MaPhong", map);
        }

        public bool CheckSave(PhongDTO pb)
        {
            if (CheckFieldData(pb.MaPhong))
            {
                MessageBox.Show("Mã này đã tồn tại trong CSDL", "Thông báo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(pb.MaPhong) ||
                string.IsNullOrWhiteSpace(pb.TenPhong) ||
                pb.GiaPhong <= 0 ||
                string.IsNullOrWhiteSpace(pb.LoaiPhong) ||
                string.IsNullOrWhiteSpace(pb.NoiThat))
            {
                MessageBox.Show("Thông tin phòng không được để trống", "Thông báo");
                return false;
            }

            return true;
        }


        public DataTable GetDataPhongByTang(string maTang)
        {
            string strquery = $"SELECT * FROM Phong WHERE MaTang = '{maTang}'";
            return dp.GetDataTable(strquery);
        }
    }
}