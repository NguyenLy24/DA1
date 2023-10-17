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
    public class BUS_TKiemSach
    {
        DAL_TKiemSach daltkiemsa = new DAL_TKiemSach();
        public DataTable getTKiemSach()
        {
            return daltkiemsa.getTKiemSach();
        }
    }
}
