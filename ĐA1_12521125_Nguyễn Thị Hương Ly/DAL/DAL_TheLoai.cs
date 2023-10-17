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
    public class DAL_TheLoai:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getTL()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from TheLoai", _con);
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
            string sql = "Select count(*) from TheLoai where MaTL='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themTL(DTO_TheLoai tl)
        {
            string sql = "Insert into TheLoai values('" + tl.MaTL + "',N'" + tl.TenTL + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaTL(DTO_TheLoai tl)
        {
            string sql = "Update TheLoai set TenTL=N'" + tl.TenTL + "' where MaTL='" + tl.MaTL + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaTL(string ma)
        {
            string sql = "Delete from TheLoai where MaTL='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
