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
    public class BUS_DangNhap
    {
        DAL_DangNhap daldn=new DAL_DangNhap();
        public DataTable getDangNhap()
        {
            return daldn.getDangNhap();
        }
        public string DangNhap(DTO_DangNhap dn)
        {
            return daldn.DangNhap(dn);
        }
    }
}
