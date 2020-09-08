using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASM
{
    class SqlStringCheck
    {
        MainDataSource ddl = new MainDataSource();

        List<string> c4 = new List<string> { "drop", "exec"};
        List<string> c5 = new List<string> { "alter", "grant" };
        List<string> c6 = new List<string> { "create", "insert", "delete", "revoke", "commit" };
        List<string> c8 = new List<string> { "truncate", "rollback" };


        public void Stringcheck(RichTextBox textBox, DataGridView dataGridView, TabPage tabPage)
        {
            try
            {
                IsCheck(textBox, dataGridView);
            }
            catch (Exception e)
            {
                tabPage.Text = e.StackTrace;
                MessageBox.Show("sql문에 문제가 있습니다.");
            }
        }
        private void IsCheck(RichTextBox textBox, DataGridView dataGridView)
        {
            textBox.Text.Trim();
            if (textBox.Text.Substring(0, 6).ToLower().Equals("select"))
            {
                dataGridView.DataSource = ddl.DoSqlSelect(textBox);
            }
            else if (c4.Contains(textBox.Text.Substring(0, 4).ToLower()))
            {
                ddl.DoSql(textBox);
            }
            else if (c5.Contains(textBox.Text.Substring(0, 5).ToLower()))
            {
                ddl.DoSql(textBox);
            }
            else if (c6.Contains(textBox.Text.Substring(0, 6).ToLower()))
            {
                ddl.DoSql(textBox);
            }
            else if (c8.Contains(textBox.Text.Substring(0, 8).ToLower()))
            {
                ddl.DoSql(textBox);
            }
            else
            {
                MessageBox.Show("sql문에 문제가 있습니다.");
            }
        }

    }
}
