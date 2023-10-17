using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NXB
    {
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChiNXB { get; set; }
        public string SDTnxb { get; set; }
        public string EmailNXB { get; set;}
        public DTO_NXB(string MaNXB, string TenNXB, string DiaChiNXB, string SDTnxb, string EmailNXB) 
        {
            this.MaNXB = MaNXB;
            this.TenNXB = TenNXB;
            this.DiaChiNXB = DiaChiNXB;
            this.SDTnxb = SDTnxb;
            this.EmailNXB = EmailNXB;
        }
    }
}
