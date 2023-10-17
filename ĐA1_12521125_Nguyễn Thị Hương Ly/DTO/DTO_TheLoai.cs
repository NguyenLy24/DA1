using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TheLoai
    {
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public DTO_TheLoai(string MaTL, string TenTL) 
        {
            this.MaTL = MaTL;
            this.TenTL = TenTL;
        }
    }
}
