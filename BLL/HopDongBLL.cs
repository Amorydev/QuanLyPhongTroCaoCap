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
    public class HopDongBLL
    {
        private readonly DataProvider dataProvider = new DataProvider();

        public DataTable GetDataHopDong()
        {
            string strquery = "SELECT * FROM HopDongThuePhong";
            return dataProvider.GetDataTable(strquery);
        }

        public void addHopDong(HopDongDTO hopDongDTO)
        {
            string formattedNgayThue = hopDongDTO.NgayThue.HasValue ? hopDongDTO.NgayThue.Value.ToString("dd/MM/yyyy") : string.Empty;
            string formattedNgayTraPhong = hopDongDTO.NgayTraPhong.ToString("dd/MM/yyyy");

            string query = $@"INSERT INTO HopDongThuePhong (MaHopDong, MaKhachHang, MaPhong, GiaPhong, TienDatCoc, NgayThue, NgayTraPhong) VALUES 
                              ('{hopDongDTO.MaHopDong}', '{hopDongDTO.MaKhachHang}', '{hopDongDTO.MaPhong}',  {hopDongDTO.GiaPhong}, {hopDongDTO.TienDatCoc}, '{formattedNgayThue}', '{formattedNgayTraPhong}')";

            if (dataProvider.RunQuery(query))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm phòng", "Thông báo lỗi");
            }
        }

        public void DeleteHopDong(HopDongDTO hopDongDTO)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlquery = $"DELETE FROM HopDongThuePhong WHERE MaHopDong = '{hopDongDTO.MaHopDong}'";

                if (dataProvider.RunQuery(sqlquery))
                {
                    MessageBox.Show("Xóa hợp đồng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa hợp đồng", "Thông báo lỗi");
                }
            }
        }
        public bool CheckFieldData(string map)
        {
            return dataProvider.CheckField("HopDongThuePhong", "MaHopDong", map);
        }

        public bool CheckSave(HopDongDTO hopDongDTO)
        {
            if (CheckFieldData(hopDongDTO.MaHopDong))
            {
                MessageBox.Show("Mã này đã tồn tại trong CSDL", "Thông báo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(hopDongDTO.MaKhachHang) ||
                string.IsNullOrWhiteSpace(hopDongDTO.MaPhong) ||
                hopDongDTO.GiaPhong <= 0 ||
                hopDongDTO.TienDatCoc <= 0 ||
                hopDongDTO.NgayThue == null ||
                hopDongDTO.NgayTraPhong == null)
            {
                MessageBox.Show("Thông tin hợp đồng không được để trống", "Thông báo");
                return false;
            }
            return true;
        }


    }
}
