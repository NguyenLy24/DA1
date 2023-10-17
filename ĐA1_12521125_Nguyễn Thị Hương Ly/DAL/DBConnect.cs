using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-LB5O5K4\SQLEXPRESS;Initial Catalog=QL_CHSach;Integrated Security=True");

    }
}
