using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public class DAL_QLSach:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getSach()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Sach", _con);
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
            string sql = "Select count(*) from Sach where MaSach='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themSach(DTO_QLSach sa)
        {
            string sql = "Insert into Sach values('" + sa.MaSach + "',N'" + sa.TenSach + "','" + sa.MaTL + "','" + sa.MaNXB + "','" + sa.DonGia + "','" + sa.SoLuong + "',N'" + sa.TacGia + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaSach(DTO_QLSach sa)
        {
            string sql = "Update Sach set TenSach=N'" + sa.TenSach + "', MaTL='" + sa.MaTL + "', MaNXB='" + sa.MaNXB + "', DonGia='" + sa.DonGia + "', SoLuong='" + sa.SoLuong + "', TacGia=N'" + sa.TacGia + "' where MaSach='" + sa.MaSach + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaSach(string ma)
        {
            string sql = "Delete from Sach where MaSach='" + ma + "'";
            thucthisql(sql);
            return true;
        }
        
    } 
}
