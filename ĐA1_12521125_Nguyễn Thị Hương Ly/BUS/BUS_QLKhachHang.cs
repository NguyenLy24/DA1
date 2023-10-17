using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_QLKhachHang
    {
        DAL_QLKhachHang dalkh = new DAL_QLKhachHang();
        public DataTable getKhachHang()
        {
            return dalkh.getKhachHang();
        }
        public int kiemtramatrung(string ma)
        {
            return dalkh.kiemtramatrung(ma);
        }
        public bool themKH(DTO_QLKhachHang kh)
        {
            if (string.IsNullOrEmpty(kh.MaKH) || string.IsNullOrEmpty(kh.HotenKH)
                || string.IsNullOrEmpty(kh.DiaChiKH) || string.IsNullOrEmpty(kh.SDTkh)
                || string.IsNullOrEmpty(kh.EmailKH))
            {
                return false;
            }
            return dalkh.themKH(kh);
        }
        public bool suaKH(DTO_QLKhachHang kh)
        {
            if (string.IsNullOrEmpty(kh.MaKH) || string.IsNullOrEmpty(kh.HotenKH)
                || string.IsNullOrEmpty(kh.DiaChiKH) || string.IsNullOrEmpty(kh.SDTkh)
                || string.IsNullOrEmpty(kh.EmailKH))
            {
                return false;
            }
            return dalkh.suaKH(kh);
        }
        public bool xoaKH(string ma)
        {
            return dalkh.xoaSV(ma);
        }
    }
}
