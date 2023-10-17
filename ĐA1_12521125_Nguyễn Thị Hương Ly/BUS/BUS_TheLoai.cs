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
    public class BUS_TheLoai
    {
        DAL_TheLoai daltl= new DAL_TheLoai();
        public DataTable getTL()
        {
            return daltl.getTL();
        }
        public int kiemtramatrung(string ma)
        {
            return daltl.kiemtramatrung(ma);
        }
        public bool themTL(DTO_TheLoai tl)
        {
            if(string.IsNullOrEmpty(tl.MaTL) || string.IsNullOrEmpty(tl.TenTL))
            {
                return false;
            }
            return daltl.themTL(tl);
        }
        public bool suaTL(DTO_TheLoai tl)
        {
            if (string.IsNullOrEmpty(tl.MaTL) || string.IsNullOrEmpty(tl.TenTL))
            {
                return false;
            }
            return daltl.suaTL(tl);
        }
        public bool xoaTL(string ma)
        {
            return daltl.xoaTL(ma);
        }
    }
}
