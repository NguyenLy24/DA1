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
    public class BUS_TKePhieuNhap
    {
        DAL_TKePhieuNhap daltkepn = new DAL_TKePhieuNhap();
        public DataTable getTKnhap()
        {
            return daltkepn.getTKnhap();
        }
    }
}
