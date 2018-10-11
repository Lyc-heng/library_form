namespace library_form
{
    partial class SearchUserControl
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
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.NameDataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.EthnicTextBox = new System.Windows.Forms.TextBox();
            this.BrithdayTextBox = new System.Windows.Forms.TextBox();
            this.RegistTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.EthnicLabel = new System.Windows.Forms.Label();
            this.BrithdayLabel = new System.Windows.Forms.Label();
            this.RegistLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchNameLabel = new System.Windows.Forms.Label();
            this.SearchIDLabel = new System.Windows.Forms.Label();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchIDTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NumberBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookWritter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameDataGridView)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberBook,
            this.BookID,
            this.BookName,
            this.BookWritter,
            this.BookTime,
            this.BookPublisher,
            this.BookPage,
            this.StartTime,
            this.EndTime});
            this.UserDataGridView.Location = new System.Drawing.Point(231, 163);
            this.UserDataGridView.MultiSelect = false;
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowTemplate.Height = 23;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(750, 134);
            this.UserDataGridView.TabIndex = 0;
            // 
            // NameDataGridView
            // 
            this.NameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            this.NameDataGridView.Location = new System.Drawing.Point(0, 0);
            this.NameDataGridView.Name = "NameDataGridView";
            this.NameDataGridView.RowTemplate.Height = 23;
            this.NameDataGridView.Size = new System.Drawing.Size(231, 297);
            this.NameDataGridView.TabIndex = 1;
            this.NameDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NameDataGridView_CellMouseDoubleClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "姓名";
            this.UserName.Name = "UserName";
            this.UserName.Width = 188;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(270, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(108, 21);
            this.NameTextBox.TabIndex = 2;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(431, 54);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(108, 21);
            this.AgeTextBox.TabIndex = 3;
            // 
            // SexTextBox
            // 
            this.SexTextBox.Location = new System.Drawing.Point(600, 54);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(108, 21);
            this.SexTextBox.TabIndex = 4;
            // 
            // EthnicTextBox
            // 
            this.EthnicTextBox.Location = new System.Drawing.Point(270, 116);
            this.EthnicTextBox.Name = "EthnicTextBox";
            this.EthnicTextBox.Size = new System.Drawing.Size(108, 21);
            this.EthnicTextBox.TabIndex = 5;
            // 
            // BrithdayTextBox
            // 
            this.BrithdayTextBox.Location = new System.Drawing.Point(431, 116);
            this.BrithdayTextBox.Name = "BrithdayTextBox";
            this.BrithdayTextBox.Size = new System.Drawing.Size(108, 21);
            this.BrithdayTextBox.TabIndex = 6;
            // 
            // RegistTextBox
            // 
            this.RegistTextBox.Location = new System.Drawing.Point(600, 116);
            this.RegistTextBox.Name = "RegistTextBox";
            this.RegistTextBox.Size = new System.Drawing.Size(108, 21);
            this.RegistTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(268, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "姓名";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(429, 39);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(29, 12);
            this.AgeLabel.TabIndex = 9;
            this.AgeLabel.Text = "年龄";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(598, 39);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(29, 12);
            this.SexLabel.TabIndex = 10;
            this.SexLabel.Text = "性别";
            // 
            // EthnicLabel
            // 
            this.EthnicLabel.AutoSize = true;
            this.EthnicLabel.Location = new System.Drawing.Point(268, 101);
            this.EthnicLabel.Name = "EthnicLabel";
            this.EthnicLabel.Size = new System.Drawing.Size(29, 12);
            this.EthnicLabel.TabIndex = 11;
            this.EthnicLabel.Text = "民族";
            // 
            // BrithdayLabel
            // 
            this.BrithdayLabel.AutoSize = true;
            this.BrithdayLabel.Location = new System.Drawing.Point(429, 101);
            this.BrithdayLabel.Name = "BrithdayLabel";
            this.BrithdayLabel.Size = new System.Drawing.Size(53, 12);
            this.BrithdayLabel.TabIndex = 12;
            this.BrithdayLabel.Text = "出生日期";
            // 
            // RegistLabel
            // 
            this.RegistLabel.AutoSize = true;
            this.RegistLabel.Location = new System.Drawing.Point(598, 101);
            this.RegistLabel.Name = "RegistLabel";
            this.RegistLabel.Size = new System.Drawing.Size(53, 12);
            this.RegistLabel.TabIndex = 13;
            this.RegistLabel.Text = "注册日期";
            // 
            // InformationLabel
            // 
            this.InformationLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InformationLabel.Location = new System.Drawing.Point(231, 140);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(100, 23);
            this.InformationLabel.TabIndex = 14;
            this.InformationLabel.Text = "所借书籍";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchPanel.Controls.Add(this.RefreshButton);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchNameLabel);
            this.SearchPanel.Controls.Add(this.SearchIDLabel);
            this.SearchPanel.Controls.Add(this.SearchNameTextBox);
            this.SearchPanel.Controls.Add(this.SearchIDTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(731, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(250, 163);
            this.SearchPanel.TabIndex = 15;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(162, 105);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "刷新";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(162, 39);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchNameLabel
            // 
            this.SearchNameLabel.AutoSize = true;
            this.SearchNameLabel.Location = new System.Drawing.Point(27, 92);
            this.SearchNameLabel.Name = "SearchNameLabel";
            this.SearchNameLabel.Size = new System.Drawing.Size(53, 12);
            this.SearchNameLabel.TabIndex = 3;
            this.SearchNameLabel.Text = "用户姓名";
            // 
            // SearchIDLabel
            // 
            this.SearchIDLabel.AutoSize = true;
            this.SearchIDLabel.Location = new System.Drawing.Point(27, 24);
            this.SearchIDLabel.Name = "SearchIDLabel";
            this.SearchIDLabel.Size = new System.Drawing.Size(41, 12);
            this.SearchIDLabel.TabIndex = 2;
            this.SearchIDLabel.Text = "用户ID";
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Location = new System.Drawing.Point(29, 107);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(112, 21);
            this.SearchNameTextBox.TabIndex = 1;
            // 
            // SearchIDTextBox
            // 
            this.SearchIDTextBox.Location = new System.Drawing.Point(29, 39);
            this.SearchIDTextBox.Name = "SearchIDTextBox";
            this.SearchIDTextBox.Size = new System.Drawing.Size(112, 21);
            this.SearchIDTextBox.TabIndex = 0;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(270, 10);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(108, 21);
            this.IDTextBox.TabIndex = 16;
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDLabel.Location = new System.Drawing.Point(241, 10);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 21);
            this.IDLabel.TabIndex = 17;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumberBook
            // 
            this.NumberBook.Frozen = true;
            this.NumberBook.HeaderText = "序号";
            this.NumberBook.Name = "NumberBook";
            // 
            // BookID
            // 
            this.BookID.HeaderText = "编号";
            this.BookID.Name = "BookID";
            // 
            // BookName
            // 
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            // 
            // BookWritter
            // 
            this.BookWritter.HeaderText = "作者";
            this.BookWritter.Name = "BookWritter";
            // 
            // BookTime
            // 
            this.BookTime.HeaderText = "出版时间";
            this.BookTime.Name = "BookTime";
            // 
            // BookPublisher
            // 
            this.BookPublisher.HeaderText = "出版社";
            this.BookPublisher.Name = "BookPublisher";
            // 
            // BookPage
            // 
            this.BookPage.HeaderText = "页数";
            this.BookPage.Name = "BookPage";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "借出时间";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "归还时间";
            this.EndTime.Name = "EndTime";
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.RegistLabel);
            this.Controls.Add(this.BrithdayLabel);
            this.Controls.Add(this.EthnicLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RegistTextBox);
            this.Controls.Add(this.BrithdayTextBox);
            this.Controls.Add(this.EthnicTextBox);
            this.Controls.Add(this.SexTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameDataGridView);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(984, 303);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameDataGridView)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.DataGridView NameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.TextBox EthnicTextBox;
        private System.Windows.Forms.TextBox BrithdayTextBox;
        private System.Windows.Forms.TextBox RegistTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label EthnicLabel;
        private System.Windows.Forms.Label BrithdayLabel;
        private System.Windows.Forms.Label RegistLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchNameLabel;
        private System.Windows.Forms.Label SearchIDLabel;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.TextBox SearchIDTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookWritter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
    }
}
