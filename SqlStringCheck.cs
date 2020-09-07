using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASM
{
    class SqlStringCheck
    {
        Ddl ddl = new Ddl();

        List<string> c6 = new List<string> { "create", "insert", "select" };

        public void string_check(RichTextBox textBox)
        {
            try
            {
                textBox.Text.Trim();
                if (c6.Contains(textBox.Text.Substring(0, 6).ToLower()))
                {
                    ddl.doSql(textBox);
                }
                else if (textBox.Text.Substring(0, 6).ToLower().Equals("insert"))
                {
                    ddl.doSql(textBox);
                }

                else
                {
                    MessageBox.Show("sql문에 문제가 있습니다.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("sql문에 문제가 있습니다.");
            }
        }
  
    }
}
