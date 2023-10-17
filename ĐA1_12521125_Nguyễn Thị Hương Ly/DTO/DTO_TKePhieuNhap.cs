using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TKePhieuNhap
    {
        public string MaPhieu { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string MaSach { get; set; }
        public float TongTienNhap { get; set; }
        public DTO_TKePhieuNhap(string maPhieu, DateTime NgayNhap, string maNV, string maSach, float tongTienNhap)
        {
            this.MaPhieu = maPhieu;
            this.NgayNhap = NgayNhap;
            this.MaNV = maNV;
            this.MaSach = maSach;
            this.TongTienNhap = tongTienNhap;
        }
    }
}
