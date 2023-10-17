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
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dalhdb = new DAL_HoaDonBan();
        public DataTable getHDB()
        {
            return dalhdb.getHDB();
        }
        public int kiemtramatrung(string ma)
        {
            return dalhdb.kiemtramatrung(ma);
        }
        public bool themHDB(DTO_HoaDonBan hdb)
        {
            if (string.IsNullOrEmpty(hdb.MaHDB) || string.IsNullOrEmpty(hdb.MaNV)
                || string.IsNullOrEmpty(hdb.MaKH) || string.IsNullOrEmpty(hdb.MaSach) 
                || hdb.TongTienBan <= 0)
            {
                return false;
            }
            return dalhdb.themHDB(hdb);
        }
        public bool suaHDB(DTO_HoaDonBan hdb)
        {
            if (string.IsNullOrEmpty(hdb.MaHDB) || string.IsNullOrEmpty(hdb.MaNV)
                || string.IsNullOrEmpty(hdb.MaKH) || string.IsNullOrEmpty(hdb.MaSach)
                || hdb.TongTienBan <= 0)
            {
                return false;
            }
            return dalhdb.suaHDB(hdb);
        }
        public bool xoaHDB(string ma)
        {
            return dalhdb.xoaHDB(ma);
        }
    }
}
