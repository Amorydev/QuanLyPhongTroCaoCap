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

        public TangDTO()
        {
        }
        public TangDTO(string maTang, string tenTang)
        {
            this.MaTang = maTang;
            this.TenTang = tenTang;
        }
    }

}
