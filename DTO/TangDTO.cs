using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TangDTO
    {
        public string MaTang { get; set; }
        public string TenTang { get; set; }


        // Constructor không tham số
        public TangDTO()
        {
        }

        // Constructor với tham số
        public TangDTO(string maTang, string tenTang)
        {
            this.MaTang = maTang;
            this.TenTang = tenTang;
        }
    }
}
