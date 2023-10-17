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
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap dalpnhap = new DAL_PhieuNhap();
        public DataTable getPhieuNhap()
        {
            return dalpnhap.getPhieuNhap();
        }
        public int kiemtramatrung(string ma)
        {
            return dalpnhap.kiemtramatrung(ma);
        }
        public bool themPhieu(DTO_PhieuNhap pn)
        {
            if (string.IsNullOrEmpty(pn.MaPhieu) || string.IsNullOrEmpty(pn.MaNV)
                || string.IsNullOrEmpty(pn.MaSach) || pn.TongTienNhap <= 0)
            {
                return false;
            }
            return dalpnhap.themPhieu(pn);
        }
        public bool suaPhieu(DTO_PhieuNhap pn)
        {
            if (string.IsNullOrEmpty(pn.MaPhieu) || string.IsNullOrEmpty(pn.MaNV)
                || string.IsNullOrEmpty(pn.MaSach) || pn.TongTienNhap <= 0)
            {
                return false;
            }
            return dalpnhap.suaPhieu(pn);
        }
        public bool xoaPhieu(string ma)
        {
            return dalpnhap.xoaPhieu(ma);
        }
    }
}
