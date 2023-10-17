using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QLSach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTL{ get; set; }
        public string MaNXB { get; set; }
        public float DonGia { get; set;}
        public int SoLuong{ get; set;}
        public string TacGia { get; set; }
        public DTO_QLSach(string maSach, string tenSach, string maTL, string maNXB, float donGia, int soLuong, string tacGia)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.MaTL = maTL;
            this.MaNXB = maNXB;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.TacGia = tacGia;
        }
    }
}
