using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThietBiDTO
    {
        public string MaThietBi {  get; set; }
        public string TenThietBi { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayMua { get; set; }
        public DateTime NgayBaoDuong { get; set; }
        public string TrangThai { get; set; }
        public float TienMua { get; set; }
        public float TienBaoDuong { get; set; }
        public string MaTang { get; set; }
    }
}
