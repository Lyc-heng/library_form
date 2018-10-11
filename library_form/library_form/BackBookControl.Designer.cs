namespace library_form
{
    partial class BackBookControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.IsRightButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WritterBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.IsRightButton);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.InformationLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 114);
            this.panel1.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(784, 64);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 21);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "刷新";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // IsRightButton
            // 
            this.IsRightButton.Location = new System.Drawing.Point(653, 62);
            this.IsRightButton.Name = "IsRightButton";
            this.IsRightButton.Size = new System.Drawing.Size(75, 23);
            this.IsRightButton.TabIndex = 5;
            this.IsRightButton.Text = "确认";
            this.IsRightButton.UseVisualStyleBackColor = true;
            this.IsRightButton.Click += new System.EventHandler(this.IsRightButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(305, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 15);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "姓名";
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDLabel.Location = new System.Drawing.Point(65, 47);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(100, 12);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(308, 62);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(141, 21);
            this.NameTextBox.TabIndex = 2;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(67, 62);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(141, 21);
            this.IDTextBox.TabIndex = 1;
            // 
            // InformationLabel
            // 
            this.InformationLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.InformationLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InformationLabel.Location = new System.Drawing.Point(0, 0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(984, 36);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "请输入用户相关信息";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.IDBook,
            this.NameBook,
            this.WritterBook,
            this.TimeBook,
            this.PublishBook,
            this.PageBook,
            this.StartTime,
            this.EndTime});
            this.UserDataGridView.Location = new System.Drawing.Point(0, 114);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowTemplate.Height = 23;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(984, 189);
            this.UserDataGridView.TabIndex = 1;
            this.UserDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserDataGridView_CellMouseDoubleClick);
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "序号";
            this.Number.Name = "Number";
            // 
            // IDBook
            // 
            this.IDBook.HeaderText = "编号";
            this.IDBook.Name = "IDBook";
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "书名";
            this.NameBook.Name = "NameBook";
            // 
            // WritterBook
            // 
            this.WritterBook.HeaderText = "作者";
            this.WritterBook.Name = "WritterBook";
            // 
            // TimeBook
            // 
            this.TimeBook.HeaderText = "出版时间";
            this.TimeBook.Name = "TimeBook";
            // 
            // PublishBook
            // 
            this.PublishBook.HeaderText = "出版社";
            this.PublishBook.Name = "PublishBook";
            // 
            // PageBook
            // 
            this.PageBook.HeaderText = "书籍页数";
            this.PageBook.Name = "PageBook";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "借出时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 150;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "还书时间";
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 150;
            // 
            // BackBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "BackBookControl";
            this.Size = new System.Drawing.Size(984, 303);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button IsRightButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn WritterBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
    }
}
