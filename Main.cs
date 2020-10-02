using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.Load += viewform_load;   // viewform_load 함수 실행

        }
        private void actionButton_Click(object sender, EventArgs e)
        {     
            check.Stringcheck(queryTextBox, dbDataGridView, logTabPage);
            logTabPage.Text = "hi";
        }
        public void viewform_load(object sender, EventArgs e)
        {
            settreeviewdata();
        }
        public void settreeviewdata()
        {
            //Table node
            entityTreeView.Nodes.Add("Table");
            entityTreeView.Nodes[0].Nodes.Add("User_info");
            entityTreeView.Nodes[0].Nodes.Add("Company_info");
            entityTreeView.Nodes[0].Nodes.Add("Recuit_info");

            //Procedure node
            entityTreeView.Nodes.Add("Procedure");
            entityTreeView.Nodes[1].Nodes.Add("DDL");
            entityTreeView.Nodes[1].Nodes[0].Nodes.Add("create");
            entityTreeView.Nodes[1].Nodes[0].Nodes.Add("alter");
            entityTreeView.Nodes[1].Nodes[0].Nodes.Add("drop");
            entityTreeView.Nodes[1].Nodes.Add("List");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("User_Select");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("User_Insert");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("User_Update");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("User_Delete");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Company_Select");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Company_Insert");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Company_Update");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Company_Delete");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Recuit_Select");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Recuit_Insert");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Recuit_Update");
            entityTreeView.Nodes[1].Nodes[1].Nodes.Add("Recuit_Delete");


            //Sequence node
            entityTreeView.Nodes.Add("Sequence");
            entityTreeView.Nodes[2].Nodes.Add("Insert_UserTable");
        }
        // Table노드의 자식 노드에 접근하는 재귀함수
        private void PrintRecursive(TreeNode treeNode)
        {
            // Print each node recursively.
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
            if (treeNode.IsSelected)
            {
                Console.WriteLine(treeNode.Text);
                if (treeNode.Text.Length > 0)
                {
                    selectTable(treeNode.Text);
                }
            }
        }
        // Table노드의 자식 노드에 접근해 Table select OR procedure 구문 조회 OR 시퀀스 구문 조회! (기능 함수)
        private void selectTable(string tableName)
        {
            // Table NODE
            if (tableName == "User_info")
            {
                SqlConnection conn = DataSource.GetConnection();
                SqlCommand cmd = new SqlCommand("select * from User_info ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dbDataGridView.DataSource = ds.Tables[0];

                cmd.ExecuteNonQuery();

                DataSource.Close(conn);
            }
            else if (tableName == "Company_info")
            {
                SqlConnection conn = DataSource.GetConnection();
                SqlCommand cmd = new SqlCommand("select * from Company_info ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dbDataGridView.DataSource = ds.Tables[0];

                cmd.ExecuteNonQuery();

                DataSource.Close(conn);
            }
            else if (tableName == "Recuit_info")
            {
                SqlConnection conn = DataSource.GetConnection();
                SqlCommand cmd = new SqlCommand("select * from Recuit_info ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dbDataGridView.DataSource = ds.Tables[0];

                cmd.ExecuteNonQuery();

                DataSource.Close(conn);
            }
            // Procedure NODE
            else if (tableName == "create")
            {
                queryTextBox.Text = ($"CREATE PROCEDURE --(프로시저명 입력) " + Environment.NewLine +

                                     "AS " + Environment.NewLine +
                                     "BEGIN " + Environment.NewLine +

                                         "SET NOCOUNT ON;" + Environment.NewLine +

                                         "END" + Environment.NewLine);
            }
            else if (tableName == "alter")
            {
                queryTextBox.Text = ($"ALTER PROCEDURE --(프로시저명 입력) " + Environment.NewLine +

                                     "AS " + Environment.NewLine +
                                     "BEGIN " + Environment.NewLine +

                                         "SET NOCOUNT ON;" + Environment.NewLine +

                                         "END" + Environment.NewLine);
            }
            else if (tableName == "drop")
            {
                queryTextBox.Text = ($"DROP PROCEDURE --(프로시저명 입력)");
            }
            else if (tableName == "User_Select")
            {
                queryTextBox.Text = ($"exec [dbo].[SelectUserInfo] @name");
            }
            else if (tableName == "User_Insert")
            {
                queryTextBox.Text = ($"exec [dbo].[InsertUserInfo] @name, @duty, @career, @Gender");
            }
            else if (tableName == "User_Update")
            {
                queryTextBox.Text = ($"exec [dbo].[UpdateUserInfo] @idx, @name, @duty, @career, @Gender");
            }
            else if (tableName == "User_Delete")
            {
                queryTextBox.Text = ($"exec [dbo].[DeleteUserInfo] @idx");
            }
            else if (tableName == "Company_Select")
            {
                queryTextBox.Text = ($"exec [dbo].[SelectCompanyInfo] @employeename");
            }
            else if (tableName == "Company_Insert")
            {
                queryTextBox.Text = ($"exec [dbo].[InsertCompanyInfo] @employeeName, @industry, @scale, @address");
            }
            else if (tableName == "Company_Update")
            {
                queryTextBox.Text = ($"exec [dbo].[UpdateCompanyInfo] @idx, @employeename, @industry, @scale, @address");
            }
            else if (tableName == "Company_Delete")
            {
                queryTextBox.Text = ($"exec [dbo].[DeleteCompanyInfo] @idx");
            }
            else if (tableName == "Recuit_Select")
            {
                queryTextBox.Text = ($"exec [dbo].[SelectRecuitInfo] @employeename");
            }
            else if (tableName == "Recuit_Insert")
            {
                queryTextBox.Text = ($"exec [dbo].[InsertRecuitInfo] @employeeName, @hireNumber, @duty, @salary, @career, @Major, @enterpriseForm");
            }
            else if (tableName == "Recuit_Update")
            {
                queryTextBox.Text = ($"exec [dbo].[UpdateRecuitInfo] @idx, @employeeName, @hireNumber, @duty, @salary, @career, @Major, @enterpriseForm");
            }
            else if (tableName == "Recuit_Delete")
            {
                queryTextBox.Text = ($"exec [dbo].[DeleteRecuitInfo] @idx");
            }
        }
        private void entityTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 형변환
            TreeView tn = sender as TreeView;
            foreach (TreeNode temp in tn.Nodes)
            {
                PrintRecursive(temp);
            }
        }
    }
}
