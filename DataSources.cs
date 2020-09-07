using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASM
{
    class DataSources
    {
        private static SqlConnection con = null;
        private static string strcon = "Data Source=192.168.0.39;Initial Catalog=RecruitDataBase;User ID=GroupA;Password=1234";

        public static SqlConnection GetConnection()
        {
            //DataSources ds = new DataSources();
            //con = new SqlConnection(ds.strcon);
            con = new SqlConnection(strcon);
            con.Open();
            return con;
        }

        public static void Close(SqlConnection con)
        {
            con.Close();
        }
    }
}
