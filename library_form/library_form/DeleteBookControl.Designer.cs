namespace library_form
{
    partial class DeleteBookControl
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
            this.ChoicBookPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.PublishLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.WritterLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.PublishTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.WritterTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ShowInformationLabel = new System.Windows.Forms.Label();
            this.BookDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ChoicBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoicBookPanel
            // 
            this.ChoicBookPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ChoicBookPanel.Controls.Add(this.NumberLabel);
            this.ChoicBookPanel.Controls.Add(this.NumberTextBox);
            this.ChoicBookPanel.Controls.Add(this.DeleteButton);
            this.ChoicBookPanel.Controls.Add(this.RefreshButton);
            this.ChoicBookPanel.Controls.Add(this.PageLabel);
            this.ChoicBookPanel.Controls.Add(this.PublishLabel);
            this.ChoicBookPanel.Controls.Add(this.TimeLabel);
            this.ChoicBookPanel.Controls.Add(this.WritterLabel);
            this.ChoicBookPanel.Controls.Add(this.NameLabel);
            this.ChoicBookPanel.Controls.Add(this.PageTextBox);
            this.ChoicBookPanel.Controls.Add(this.PublishTextBox);
            this.ChoicBookPanel.Controls.Add(this.TimeTextBox);
            this.ChoicBookPanel.Controls.Add(this.WritterTextBox);
            this.ChoicBookPanel.Controls.Add(this.NameTextBox);
            this.ChoicBookPanel.Controls.Add(this.ShowInformationLabel);
            this.ChoicBookPanel.Location = new System.Drawing.Point(0, 0);
            this.ChoicBookPanel.Name = "ChoicBookPanel";
            this.ChoicBookPanel.Size = new System.Drawing.Size(984, 100);
            this.ChoicBookPanel.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeleteButton.Location = new System.Drawing.Point(906, 55);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.RefreshButton.Location = new System.Drawing.Point(906, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "刷新";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(769, 42);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(29, 12);
            this.PageLabel.TabIndex = 10;
            this.PageLabel.Text = "页数";
            // 
            // PublishLabel
            // 
            this.PublishLabel.AutoSize = true;
            this.PublishLabel.Location = new System.Drawing.Point(618, 42);
            this.PublishLabel.Name = "PublishLabel";
            this.PublishLabel.Size = new System.Drawing.Size(41, 12);
            this.PublishLabel.TabIndex = 9;
            this.PublishLabel.Text = "出版社";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(467, 42);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(53, 12);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "出版时间";
            // 
            // WritterLabel
            // 
            this.WritterLabel.AutoSize = true;
            this.WritterLabel.Location = new System.Drawing.Point(316, 42);
            this.WritterLabel.Name = "WritterLabel";
            this.WritterLabel.Size = new System.Drawing.Size(29, 12);
            this.WritterLabel.TabIndex = 7;
            this.WritterLabel.Text = "作者";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(165, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "名字";
            // 
            // PageTextBox
            // 
            this.PageTextBox.Location = new System.Drawing.Point(771, 57);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(100, 21);
            this.PageTextBox.TabIndex = 5;
            // 
            // PublishTextBox
            // 
            this.PublishTextBox.Location = new System.Drawing.Point(620, 57);
            this.PublishTextBox.Name = "PublishTextBox";
            this.PublishTextBox.Size = new System.Drawing.Size(100, 21);
            this.PublishTextBox.TabIndex = 4;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(469, 57);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.TimeTextBox.TabIndex = 3;
            // 
            // WritterTextBox
            // 
            this.WritterTextBox.Location = new System.Drawing.Point(318, 57);
            this.WritterTextBox.Name = "WritterTextBox";
            this.WritterTextBox.Size = new System.Drawing.Size(100, 21);
            this.WritterTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(167, 57);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 21);
            this.NameTextBox.TabIndex = 1;
            // 
            // ShowInformationLabel
            // 
            this.ShowInformationLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowInformationLabel.Location = new System.Drawing.Point(3, 0);
            this.ShowInformationLabel.Name = "ShowInformationLabel";
            this.ShowInformationLabel.Size = new System.Drawing.Size(173, 23);
            this.ShowInformationLabel.TabIndex = 0;
            this.ShowInformationLabel.Text = "选择需要删除的书籍";
            this.ShowInformationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BookDataGridView
            // 
            this.BookDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.BookNumber,
            this.BookName,
            this.Writter,
            this.PublishTime,
            this.Publisher,
            this.Page,
            this.Borrow});
            this.BookDataGridView.Location = new System.Drawing.Point(0, 98);
            this.BookDataGridView.MultiSelect = false;
            this.BookDataGridView.Name = "BookDataGridView";
            this.BookDataGridView.RowTemplate.Height = 23;
            this.BookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BookDataGridView.Size = new System.Drawing.Size(984, 202);
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
            this.BookName.Width = 200;
            // 
            // Writter
            // 
            this.Writter.HeaderText = "作者";
            this.Writter.Name = "Writter";
            this.Writter.Width = 200;
            // 
            // PublishTime
            // 
            this.PublishTime.HeaderText = "出版时间";
            this.PublishTime.Name = "PublishTime";
            this.PublishTime.Width = 200;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "出版社";
            this.Publisher.Name = "Publisher";
            this.Publisher.Width = 200;
            // 
            // Page
            // 
            this.Page.HeaderText = "页数";
            this.Page.Name = "Page";
            this.Page.Width = 200;
            // 
            // Borrow
            // 
            this.Borrow.HeaderText = "是否可借阅";
            this.Borrow.Name = "Borrow";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(16, 57);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.NumberTextBox.TabIndex = 13;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(14, 42);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(29, 12);
            this.NumberLabel.TabIndex = 14;
            this.NumberLabel.Text = "编号";
            // 
            // DeleteBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BookDataGridView);
            this.Controls.Add(this.ChoicBookPanel);
            this.Name = "DeleteBookControl";
            this.Size = new System.Drawing.Size(984, 303);
            this.ChoicBookPanel.ResumeLayout(false);
            this.ChoicBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChoicBookPanel;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Label PublishLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label WritterLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PageTextBox;
        private System.Windows.Forms.TextBox PublishTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox WritterTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ShowInformationLabel;
        private System.Windows.Forms.DataGridView BookDataGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrow;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label NumberLabel;
    }
}
