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
    public class BUS_QLSach
    {
        DAL_QLSach dalsach = new DAL_QLSach();
        public DataTable getSach()
        {
            return dalsach.getSach();
        }
        public int kiemtramatrung(string ma)
        {
            return dalsach.kiemtramatrung(ma);
        }
        public bool themSach(DTO_QLSach sa)
        {
            if (string.IsNullOrEmpty(sa.MaSach) || string.IsNullOrEmpty(sa.TenSach)
                || string.IsNullOrEmpty(sa.MaTL) || string.IsNullOrEmpty(sa.MaNXB)
                || sa.DonGia <= 0 || sa.SoLuong <= 0 || string.IsNullOrEmpty(sa.TacGia))
            {
                return false;
            }
            return dalsach.themSach(sa);
        }
        public bool suaSach(DTO_QLSach sa)
        {
            if (string.IsNullOrEmpty(sa.MaSach) || string.IsNullOrEmpty(sa.TenSach)
                || string.IsNullOrEmpty(sa.MaTL) || string.IsNullOrEmpty(sa.MaNXB)
                || sa.DonGia <= 0 || sa.SoLuong <= 0 || string.IsNullOrEmpty(sa.TacGia))
            {
                return false;
            }
            return dalsach.suaSach(sa);
        }
        public bool xoaSach(string ma)
        {
            return dalsach.xoaSach(ma);
        }
       
    }
}
