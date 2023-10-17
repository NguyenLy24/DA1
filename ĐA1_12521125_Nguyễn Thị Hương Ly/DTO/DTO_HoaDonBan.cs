using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        public string MaHDB { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string MaSach { get; set; }
        public float TongTienBan { get; set; }
        public DTO_HoaDonBan(string maHDB, DateTime NgayBan, string maNV, string maKH, string maSach, float tongTienBan)
        {
            this.MaHDB = maHDB;
            this.NgayBan = NgayBan;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.MaSach = maSach;
            this.TongTienBan = tongTienBan;
        }
    }
}
