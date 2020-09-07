using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASM
{
    class Ddl
    {
        public void doSql(RichTextBox textBox)
        {
            try
            {
                SqlConnection conn = DataSources.GetConnection();
                SqlCommand cmd = new SqlCommand(textBox.Text, conn);
                cmd.ExecuteNonQuery();
                DataSources.Close(conn);
                MessageBox.Show("Test");
            }
            catch (Exception)
            {
                MessageBox.Show("sql문에 문제가 있습니다.");
            }

        }
    }
}
