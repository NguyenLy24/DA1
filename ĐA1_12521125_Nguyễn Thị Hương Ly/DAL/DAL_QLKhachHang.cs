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
    public class DAL_QLKhachHang:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getKhachHang()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from KhachHang", _con);
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
            string sql = "Select count(*) from KhachHang where MaKH='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themKH(DTO_QLKhachHang kh)
        {
            string ngayDatDon = string.Format("{0}/{1}/{2}", kh.NgayDatDon.Year, kh.NgayDatDon.Month, kh.NgayDatDon.Day);
            string sql = "Insert into KhachHang values('" + kh.MaKH + "',N'" + kh.HotenKH + "',N'" + kh.DiaChiKH + "','" + kh.SDTkh + "','" + kh.EmailKH + "','" + ngayDatDon + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaKH(DTO_QLKhachHang kh)
        {
            string ngayDatDon = string.Format("{0}/{1}/{2}", kh.NgayDatDon.Year, kh.NgayDatDon.Month, kh.NgayDatDon.Day);
            string sql = "Update KhachHang set HotenKH=N'" + kh.HotenKH + "', DiaChiKH=N'" + kh.DiaChiKH + "', SDTkh='" +kh.SDTkh + "', EmailKH='" +kh.EmailKH + "', NgayDatDon='" +ngayDatDon + "' where MaKH='" + kh.MaKH + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaSV(string ma)
        {
            string sql = "Delete from KhachHang where MaKH='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
