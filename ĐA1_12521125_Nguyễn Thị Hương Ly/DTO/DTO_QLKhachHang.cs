using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QLKhachHang
    {
        public string MaKH { get; set; }
        public string HotenKH { get; set;}
        public string DiaChiKH { get; set;}
        public string SDTkh { get; set; }
        public string EmailKH { get; set;}
        public DateTime NgayDatDon { get; set; }
        public DTO_QLKhachHang(string maKH, string hotenKH, string diaChiKH, string sdtKH, string emailKH, DateTime ngayDatDon)
        {
            this.MaKH = maKH;
            this.HotenKH = hotenKH;
            this.DiaChiKH = diaChiKH;
            this.SDTkh = sdtKH;
            this.EmailKH = emailKH;
            this.NgayDatDon = ngayDatDon;
        }
    }
}
