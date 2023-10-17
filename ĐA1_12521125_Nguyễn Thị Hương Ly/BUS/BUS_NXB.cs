using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BUS
{
    public class BUS_NXB
    {
        DAL_NXB dalnxb = new DAL_NXB();
        public DataTable getNXB()
        {
            return dalnxb.getNXB();
        }
        public int kiemtramatrung(string ma)
        {
            return dalnxb.kiemtramatrung(ma);
        }
        public bool themNXB(DTO_NXB nxb)
        {
            if (string.IsNullOrEmpty(nxb.MaNXB) || string.IsNullOrEmpty(nxb.TenNXB)
                || string.IsNullOrEmpty(nxb.DiaChiNXB) || string.IsNullOrEmpty(nxb.SDTnxb)
                || string.IsNullOrEmpty(nxb.EmailNXB))
            {
                return false;
            }
            return dalnxb.themNXB(nxb);
        }
        public bool suaNXB(DTO_NXB nxb)
        {
            if (string.IsNullOrEmpty(nxb.MaNXB) || string.IsNullOrEmpty(nxb.TenNXB)
                || string.IsNullOrEmpty(nxb.DiaChiNXB) || string.IsNullOrEmpty(nxb.SDTnxb)
                || string.IsNullOrEmpty(nxb.EmailNXB))
            {
                return false;
            }
            return dalnxb.suaNXB(nxb);
        }
        public bool xoaNXB(string ma)
        {
            return dalnxb.xoaNXB(ma);
        }
    }
}
