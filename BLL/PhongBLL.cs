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
        private readonly DataProvider dataProvider = new DataProvider();

        public DataTable GetDataPhong()
        {
            string strquery = "SELECT * FROM Phong";
            return dataProvider.GetDataTable(strquery);
        }
        

        public void AddPhong(PhongDTO phongDTO)
        {
            string sqlquery = $@"INSERT INTO Phong (MaPhong, TenPhong, LoaiPhong, GiaPhong, NoiThat, MaTang, TrangThai)
                                VALUES ('{phongDTO.MaPhong}', N'{phongDTO.TenPhong}', N'{phongDTO.LoaiPhong}', {phongDTO.GiaPhong}, N'{phongDTO.NoiThat}', '{phongDTO.MaTang}', N'{phongDTO.TrangThai}')";

            if (dataProvider.RunQuery(sqlquery))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm phòng", "Thông báo lỗi");
            }
        }

        public void UpdatePhong(PhongDTO phongDTO)
        {
            string sqlquery = $@"UPDATE Phong SET 
                                TenPhong = N'{phongDTO.TenPhong}', 
                                LoaiPhong = N'{phongDTO.LoaiPhong}', 
                                GiaPhong = {phongDTO.GiaPhong}, 
                                NoiThat = N'{phongDTO.NoiThat}', 
                                MaTang = '{phongDTO.MaTang}', 
                                TrangThai = N'{phongDTO.TrangThai}' 
                                WHERE 
                                MaPhong = '{phongDTO.MaPhong}'";

            if (dataProvider.RunQuery(sqlquery))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật phòng", "Thông báo lỗi");
            }
        }

        public void DeletePhong(PhongDTO phongDTO)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlquery = $"DELETE FROM Phong WHERE MaPhong = '{phongDTO.MaPhong}'";

                if (dataProvider.RunQuery(sqlquery))
                {
                    MessageBox.Show("Xóa phòng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa phòng", "Thông báo lỗi");
                }
            }
        }

        public bool CheckFieldData(string map)
        {
            return dataProvider.CheckField("Phong", "MaPhong", map);
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

        public PhongDTO GetPhongByMaPhong(string maPhong)
        {
            PhongDTO phongDTO = null;

            string query = "SELECT * FROM Phong WHERE MaPhong = @MaPhong";
            var parameter = new SqlParameter("@MaPhong", maPhong);

            using (var connection = new SqlConnection("Data Source=DESKTOP-2M3CSSN\\MSSQLSERVER02;Initial Catalog=QLPhongTroCaoCap;Integrated Security=True;Encrypt=False"))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(parameter);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            phongDTO = new PhongDTO
                            {
                                MaPhong = reader["MaPhong"].ToString(),
                                TenPhong = reader["TenPhong"].ToString(),
                                LoaiPhong = reader["LoaiPhong"].ToString(),
                                GiaPhong = Convert.ToSingle(reader["GiaPhong"]),
                                NoiThat = reader["NoiThat"].ToString(),
                                MaTang = reader["MaTang"].ToString(),
                                TrangThai = reader["TrangThai"].ToString()
                            };
                        }
                    }
                }
            }

            return phongDTO;
        }
    }
}