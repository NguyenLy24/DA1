using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public DTO_DangNhap(string TenDangNhap, string MatKhau)
        {
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
    }
}
