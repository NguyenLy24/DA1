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
    public class DAL_DangNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable getDangNhap()
        {
            _con.Open();
            da=new SqlDataAdapter("select * from DangNhap",_con);
            dt=new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public string DangNhap(DTO_DangNhap dn)
        {
            string id = "";
            try
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap WHERE TenDangNhap = N'" + dn.TenDangNhap + "' AND MatKhau = N'" + dn.MatKhau + "'", _con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["TenDangNhap"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                _con.Close();
            }
            return id;
        }
    }
}
