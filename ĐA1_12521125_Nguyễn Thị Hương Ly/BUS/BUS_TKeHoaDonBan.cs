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
    public class BUS_TKeHoaDonBan
    {
        DAL_TKeHoaDonBan daltkehdb = new DAL_TKeHoaDonBan();
        public DataTable getTKeban()
        {
            return daltkehdb.getTKeban();
        }
    }
}
