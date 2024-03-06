using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    internal class sqlbaglantisi
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=YILKAR-MIKRO;Initial Catalog=MikroDB_V16_YILKAR16;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
