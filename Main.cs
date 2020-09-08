using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASM
{
    public partial class Main : Form
    {
        SqlStringCheck check = new SqlStringCheck();
        public Main()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            string a = check.SqlCensor(queryTextBox);
            check.Stringcheck(queryTextBox, dbDataGridView, logTabPage);
            logTabPage.Text = "hi";
        }
    }
}
