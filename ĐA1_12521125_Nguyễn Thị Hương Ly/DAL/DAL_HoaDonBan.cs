using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_HoaDonBan:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getHDB()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HoaDonBan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from HoaDonBan where MaHDB='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themHDB(DTO_HoaDonBan hdb)
        {
            string ngayBan = string.Format("{0}/{1}/{2}", hdb.NgayBan.Year, hdb.NgayBan.Month, hdb.NgayBan.Day);
            string sql = "Insert into HoaDonBan values('" + hdb.MaHDB + "','" + ngayBan + "','" + hdb.MaNV + "','" + hdb.MaKH + "','" + hdb.MaSach + "','" + hdb.TongTienBan + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaHDB(DTO_HoaDonBan hdb)
        {
            string ngayBan = string.Format("{0}/{1}/{2}", hdb.NgayBan.Year, hdb.NgayBan.Month, hdb.NgayBan.Day);
            string sql = "Update HoaDonBan set NgayBan='" + ngayBan + "', MaNV='" + hdb.MaNV + "', MaKH='" + hdb.MaKH + "', MaSach='" + hdb.MaSach + "', TongTienBan='" + hdb.TongTienBan + "' where MaHDB='" + hdb.MaHDB + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaHDB(string ma)
        {
            string sql = "Delete from HoaDonBan where MaHDB='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
