namespace library_form
{
    partial class SearchBookControl
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
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookWritter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.WritterTextBox = new System.Windows.Forms.TextBox();
            this.WritterLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PublishTextBox = new System.Windows.Forms.TextBox();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.PageLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.BookNumber,
            this.BookName,
            this.BookWritter,
            this.AddBookName,
            this.BookPublish,
            this.BookPage,
            this.Borrow,
            this.BorrowStartTime,
            this.BorrowEndTime});
            this.BookDataGridView.Location = new System.Drawing.Point(3, 83);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.RowTemplate.Height = 23;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(978, 220);
            this.BookDataGridView.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "序号";
            this.Number.Name = "Number";
            // 
            // BookNumber
            // 
            this.BookNumber.HeaderText = "编号";
            this.BookNumber.Name = "BookNumber";
            this.BookNumber.Width = 120;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            this.BookName.Width = 135;
            // 
            // BookWritter
            // 
            this.BookWritter.HeaderText = "作者";
            this.BookWritter.Name = "BookWritter";
            this.BookWritter.Width = 200;
            // 
            // AddBookName
            // 
            this.AddBookName.HeaderText = "书籍出版时间";
            this.AddBookName.Name = "AddBookName";
            this.AddBookName.Width = 200;
            // 
            // BookPublish
            // 
            this.BookPublish.HeaderText = "出版社";
            this.BookPublish.Name = "BookPublish";
            this.BookPublish.Width = 200;
            // 
            // BookPage
            // 
            this.BookPage.HeaderText = "书籍页数";
            this.BookPage.Name = "BookPage";
            this.BookPage.Width = 200;
            // 
            // Borrow
            // 
            this.Borrow.HeaderText = "是否可借阅";
            this.Borrow.Name = "Borrow";
            // 
            // BorrowStartTime
            // 
            this.BorrowStartTime.HeaderText = "借出时间";
            this.BorrowStartTime.Name = "BorrowStartTime";
            // 
            // BorrowEndTime
            // 
            this.BorrowEndTime.HeaderText = "还书时间";
            this.BorrowEndTime.Name = "BorrowEndTime";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.RefreshButton.Location = new System.Drawing.Point(906, 54);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "刷新";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(136, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 21);
            this.NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(135, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "书名";
            // 
            // WritterTextBox
            // 
            this.WritterTextBox.Location = new System.Drawing.Point(266, 54);
            this.WritterTextBox.Name = "WritterTextBox";
            this.WritterTextBox.Size = new System.Drawing.Size(100, 21);
            this.WritterTextBox.TabIndex = 4;
            // 
            // WritterLabel
            // 
            this.WritterLabel.AutoSize = true;
            this.WritterLabel.Location = new System.Drawing.Point(264, 39);
            this.WritterLabel.Name = "WritterLabel";
            this.WritterLabel.Size = new System.Drawing.Size(29, 12);
            this.WritterLabel.TabIndex = 5;
            this.WritterLabel.Text = "作者";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(390, 54);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.TimeTextBox.TabIndex = 6;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(388, 39);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(53, 12);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "出版时间";
            // 
            // PublishTextBox
            // 
            this.PublishTextBox.Location = new System.Drawing.Point(520, 54);
            this.PublishTextBox.Name = "PublishTextBox";
            this.PublishTextBox.Size = new System.Drawing.Size(100, 21);
            this.PublishTextBox.TabIndex = 8;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(518, 39);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(41, 12);
            this.PublisherLabel.TabIndex = 9;
            this.PublisherLabel.Text = "出版社";
            // 
            // PageTextBox
            // 
            this.PageTextBox.Location = new System.Drawing.Point(650, 54);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(100, 21);
            this.PageTextBox.TabIndex = 10;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(648, 39);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(29, 12);
            this.PageLabel.TabIndex = 11;
            this.PageLabel.Text = "页数";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Location = new System.Drawing.Point(816, 54);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(6, 54);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.NumberTextBox.TabIndex = 13;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(3, 39);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(29, 12);
            this.NumberLabel.TabIndex = 14;
            this.NumberLabel.Text = "编号";
            // 
            // SearchBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.PageTextBox);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.PublishTextBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.WritterLabel);
            this.Controls.Add(this.WritterTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BookDataGridView);
            this.Name = "SearchBookControl";
            this.Size = new System.Drawing.Size(984, 303);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookDataGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox WritterTextBox;
        private System.Windows.Forms.Label WritterLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox PublishTextBox;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.TextBox PageTextBox;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookWritter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrow;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowEndTime;
    }
}
