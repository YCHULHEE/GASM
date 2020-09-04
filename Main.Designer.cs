namespace GASM
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("노드1");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("노드2");
            this.dbDataGridView = new System.Windows.Forms.DataGridView();
            this.dbTabControl = new System.Windows.Forms.TabControl();
            this.resultTabPage = new System.Windows.Forms.TabPage();
            this.MessageTabPage = new System.Windows.Forms.TabPage();
            this.entityTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).BeginInit();
            this.dbTabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDataGridView
            // 
            this.dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView.Location = new System.Drawing.Point(178, 3);
            this.dbDataGridView.Name = "dbDataGridView";
            this.dbDataGridView.RowTemplate.Height = 23;
            this.dbDataGridView.Size = new System.Drawing.Size(776, 442);
            this.dbDataGridView.TabIndex = 0;
            // 
            // dbTabControl
            // 
            this.dbTabControl.Controls.Add(this.resultTabPage);
            this.dbTabControl.Controls.Add(this.MessageTabPage);
            this.dbTabControl.Location = new System.Drawing.Point(178, 446);
            this.dbTabControl.Name = "dbTabControl";
            this.dbTabControl.SelectedIndex = 0;
            this.dbTabControl.Size = new System.Drawing.Size(776, 194);
            this.dbTabControl.TabIndex = 1;
            // 
            // resultTabPage
            // 
            this.resultTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultTabPage.Name = "resultTabPage";
            this.resultTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultTabPage.Size = new System.Drawing.Size(768, 168);
            this.resultTabPage.TabIndex = 0;
            this.resultTabPage.Text = "결과";
            this.resultTabPage.UseVisualStyleBackColor = true;
            // 
            // MessageTabPage
            // 
            this.MessageTabPage.Location = new System.Drawing.Point(4, 22);
            this.MessageTabPage.Name = "MessageTabPage";
            this.MessageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MessageTabPage.Size = new System.Drawing.Size(768, 168);
            this.MessageTabPage.TabIndex = 1;
            this.MessageTabPage.Text = "메세지";
            this.MessageTabPage.UseVisualStyleBackColor = true;
            // 
            // entityTreeView
            // 
            this.entityTreeView.Location = new System.Drawing.Point(0, 4);
            this.entityTreeView.Name = "entityTreeView";
            treeNode7.Name = "노드3";
            treeNode7.Text = "노드3";
            treeNode8.Name = "노드4";
            treeNode8.Text = "노드4";
            treeNode9.Name = "노드5";
            treeNode9.Text = "노드5";
            treeNode10.Name = "노드0";
            treeNode10.Text = "노드0";
            treeNode11.Name = "노드1";
            treeNode11.Text = "노드1";
            treeNode12.Name = "노드2";
            treeNode12.Text = "노드2";
            this.entityTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.entityTreeView.Size = new System.Drawing.Size(178, 636);
            this.entityTreeView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.프로젝트PToolStripMenuItem,
            this.도구TToolStripMenuItem,
            this.창WToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메ToolStripMenuItem
            // 
            this.메ToolStripMenuItem.Name = "메ToolStripMenuItem";
            this.메ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.메ToolStripMenuItem.Text = "파일(F)";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기VToolStripMenuItem.Text = "보기(V)";
            // 
            // 프로젝트PToolStripMenuItem
            // 
            this.프로젝트PToolStripMenuItem.Name = "프로젝트PToolStripMenuItem";
            this.프로젝트PToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.프로젝트PToolStripMenuItem.Text = "프로젝트(P)";
            // 
            // 도구TToolStripMenuItem
            // 
            this.도구TToolStripMenuItem.Name = "도구TToolStripMenuItem";
            this.도구TToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.도구TToolStripMenuItem.Text = "도구(T)";
            // 
            // 창WToolStripMenuItem
            // 
            this.창WToolStripMenuItem.Name = "창WToolStripMenuItem";
            this.창WToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.창WToolStripMenuItem.Text = "창(W)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.resetButton);
            this.mainPanel.Controls.Add(this.actionButton);
            this.mainPanel.Controls.Add(this.queryLabel);
            this.mainPanel.Controls.Add(this.queryTextBox);
            this.mainPanel.Controls.Add(this.entityTreeView);
            this.mainPanel.Controls.Add(this.dbDataGridView);
            this.mainPanel.Controls.Add(this.dbTabControl);
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1288, 711);
            this.mainPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1182, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 32);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1070, 446);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 32);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "초기화";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(960, 446);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(103, 32);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "실행";
            this.actionButton.UseVisualStyleBackColor = true;
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.queryLabel.Location = new System.Drawing.Point(1062, 16);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(139, 16);
            this.queryLabel.TabIndex = 3;
            this.queryLabel.Text = "SQL 쿼리문 작성";
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(960, 44);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(325, 401);
            this.queryTextBox.TabIndex = 2;
            this.queryTextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "AGroupManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).EndInit();
            this.dbTabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbDataGridView;
        private System.Windows.Forms.TabControl dbTabControl;
        private System.Windows.Forms.TabPage resultTabPage;
        private System.Windows.Forms.TabPage MessageTabPage;
        private System.Windows.Forms.TreeView entityTreeView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.RichTextBox queryTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button actionButton;
    }
}

