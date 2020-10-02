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

        //List<string> c3 = new List<string> { "USE" };
        List<string> c4 = new List<string> { "drop", "exec"};
        List<string> c5 = new List<string> { "alter"};
        List<string> c6 = new List<string> { "create", "insert", "delete", "select", "update" };
        List<string> c8 = new List<string> { "truncate", "rollback" };


        public void Stringcheck(RichTextBox textBox, DataGridView dataGridView, TabPage tabPage) // 
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
                if((textBox.Text.Substring(0, 4).ToLower()).Equals("exec"))
                {
                    dataGridView.DataSource = ddl.DoSqlSelect(textBox);
                }
                else
                {
                    ddl.DoSql(textBox);
                }
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

        public string SqlCensor(RichTextBox textBox) // Sql문 검사하여 문자열 정리 후 자동 완성하는 기능(미구현)
         {
            string[] censor;
            string result = "";
            char[] sep = { ';' };
            censor = textBox.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in censor)
            {
                result = item;
            }
            result.Trim();
            return result;
        }
    }
}
