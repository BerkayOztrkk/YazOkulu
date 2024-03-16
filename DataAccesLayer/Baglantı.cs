using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesLayer
{
    public class Baglantı
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-P65FJRU\SQLEXPRESS;Initial Catalog=dbYazOkulu;Integrated Security=True;");
    }
}
