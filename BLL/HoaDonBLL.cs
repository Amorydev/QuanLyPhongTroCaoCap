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
    public class HoaDonBLL
    {
        DataProvider dataProvider = new DataProvider();

        public DataTable GetDataHoaDon()
        {
            string strquery = "SELECT * FROM HoaDonThang";
            return dataProvider.GetDataTable(strquery);
        }
        public void addHoaDon(HoaDonDTO hoaDonDTO)
        {  
            string formattedTuNgay = hoaDonDTO.TuNgay.HasValue ? hoaDonDTO.TuNgay.Value.ToString("yyyy-MM-dd") : "NULL";
            string formattedToiNgay = hoaDonDTO.ToiNgay.HasValue ? hoaDonDTO.ToiNgay.Value.ToString("yyyy-MM-dd") : "NULL";
            string formattedTienPhong = hoaDonDTO.TienPhong.HasValue ? hoaDonDTO.TienPhong.Value.ToString().Replace(",", ".") : "NULL";
            string formattedTienDien = hoaDonDTO.TienDien.HasValue ? hoaDonDTO.TienDien.Value.ToString().Replace(",", ".") : "NULL";
            string formattedTienNuoc = hoaDonDTO.TienNuoc.HasValue ? hoaDonDTO.TienNuoc.Value.ToString().Replace(",", ".") : "NULL";
            string formattedTienDichVu = hoaDonDTO.TienDichVu.HasValue ? hoaDonDTO.TienDichVu.Value.ToString().Replace(",", ".") : "NULL";
            string formattedTongTien = hoaDonDTO.TongTien.HasValue ? hoaDonDTO.TongTien.Value.ToString().Replace(",", ".") : "NULL";

            string query = $@"INSERT INTO HoaDonThang (MaHoaDon, MaPhong, TuNgay, ToiNgay, TienPhong, TienDien, TienNuoc, TienDichVu, TongTien) 
                      VALUES ('{hoaDonDTO.MaHoaDon}', '{hoaDonDTO.MaPhong}', 
                      {(formattedTuNgay != "NULL" ? $"'{formattedTuNgay}'" : "NULL")}, 
                      {(formattedToiNgay != "NULL" ? $"'{formattedToiNgay}'" : "NULL")}, 
                      {formattedTienPhong}, {formattedTienDien}, {formattedTienNuoc}, {formattedTienDichVu}, {formattedTongTien})";

            if (dataProvider.RunQuery(query))
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn", "Thông báo lỗi");
            }
        }
        public bool CheckSave(HoaDonDTO hoaDonDTO)
        {
            if (CheckFieldData(hoaDonDTO.MaHoaDon))
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại trong CSDL", "Thông báo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(hoaDonDTO.MaPhong) ||
                hoaDonDTO.TuNgay == null ||
                hoaDonDTO.ToiNgay == null ||
                hoaDonDTO.TienPhong <= 0 ||
                hoaDonDTO.TienDien < 0 ||  
                hoaDonDTO.TienNuoc < 0 ||  
                hoaDonDTO.TienDichVu < 0 || 
                hoaDonDTO.TongTien <= 0)
            {
                MessageBox.Show("Thông tin hóa đơn không hợp lệ hoặc bị thiếu", "Thông báo");
                return false;
            }

            return true;
        }
        public bool CheckFieldData(string map)
        {
            return dataProvider.CheckField("HoaDonThang", "MaHoaDon", map);
        }


    }
}
