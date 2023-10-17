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
    public class DAL_PhieuNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getPhieuNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from PhieuNhap", _con);
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
            string sql = "Select count(*) from PhieuNhap where MaPhieu='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themPhieu(DTO_PhieuNhap pn)
        {
            string ngayNhap = string.Format("{0}/{1}/{2}", pn.NgayNhap.Year, pn.NgayNhap.Month, pn.NgayNhap.Day);
            string sql = "Insert into PhieuNhap values('" + pn.MaPhieu + "','" + ngayNhap + "',N'" + pn.MaNV + "','" + pn.MaSach + "','" + pn.TongTienNhap + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaPhieu(DTO_PhieuNhap pn)
        {
            string ngayNhap = string.Format("{0}/{1}/{2}", pn.NgayNhap.Year, pn.NgayNhap.Month, pn.NgayNhap.Day);
            string sql = "Update PhieuNhap set NgayNhap='" + ngayNhap + "', MaNV='" + pn.MaNV + "', MaSach='" + pn.MaSach + "', TongTienNhap='" + pn.TongTienNhap + "' where MaPhieu='" + pn.MaPhieu + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaPhieu(string ma)
        {
            string sql = "Delete from PhieuNhap where MaPhieu='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
