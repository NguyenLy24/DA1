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
    public class DAL_NXB:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getNXB()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NXB", _con);
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
            string sql = "Select count(*) from NXB where MaNXB='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool themNXB(DTO_NXB nxb)
        {
            string sql = "Insert into NXB values('" + nxb.MaNXB + "',N'" + nxb.TenNXB + "',N'" + nxb.DiaChiNXB + "','" + nxb.SDTnxb + "','" + nxb.EmailNXB + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNXB(DTO_NXB nxb)
        {
            string sql = "Update NXB set TenNXB=N'" + nxb.TenNXB + "', DiaChiNXB=N'" + nxb.DiaChiNXB + "', SDTnxb='" + nxb.SDTnxb + "', EmailNXB='" + nxb.EmailNXB + "' where MaNXB='" + nxb.MaNXB + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaNXB(string ma)
        {
            string sql = "Delete from NXB where MaNXB='" + ma + "'";
            thucthisql(sql);
            return true;
        }
    }
}
