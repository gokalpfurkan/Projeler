using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ŞİRKETOTOMASYONU
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection b = new SqlConnection(@"Data Source=DESKTOP-N0PVHKV;Initial Catalog=DBOSİRKETOTOMASYONU;Integrated Security=True;");
                b.Open();
                return b;
        }
    }
}
