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
    class MainDataSource
    {

        public void DoSql(RichTextBox textBox)
        {
            try
            {
                SqlConnection conn = DataSource.GetConnection();
                SqlCommand cmd = new SqlCommand(textBox.Text, conn);
                cmd.ExecuteNonQuery();
                DataSource.Close(conn);
            }
            catch (Exception e)
            {
                MessageBox.Show("sql문에 문제가 있습니다.");
            }
        }

        public DataTable DoSqlSelect(RichTextBox textBox)
        {
            try
            {
                SqlConnection conn = DataSource.GetConnection();
                SqlCommand cmd = new SqlCommand(textBox.Text, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DataSource.Close(conn);
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                DataSet ds = new DataSet();
                MessageBox.Show("sql문에 문제가 있습니다.");
                return ds.Tables[0];
            }
        }
    }
}
