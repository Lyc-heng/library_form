namespace library_form
{
    partial class AddBookControl
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
            this.BookName = new System.Windows.Forms.TextBox();
            this.Writter = new System.Windows.Forms.TextBox();
            this.PublishCompany = new System.Windows.Forms.TextBox();
            this.Page = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RightButton = new System.Windows.Forms.Button();
            this.BookLabel = new System.Windows.Forms.Label();
            this.WritterLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PublishLabel = new System.Windows.Forms.Label();
            this.Pagelabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(45, 80);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(192, 21);
            this.BookName.TabIndex = 0;
            // 
            // Writter
            // 
            this.Writter.Location = new System.Drawing.Point(302, 80);
            this.Writter.Name = "Writter";
            this.Writter.Size = new System.Drawing.Size(192, 21);
            this.Writter.TabIndex = 1;
            // 
            // PublishCompany
            // 
            this.PublishCompany.Location = new System.Drawing.Point(45, 221);
            this.PublishCompany.Name = "PublishCompany";
            this.PublishCompany.Size = new System.Drawing.Size(192, 21);
            this.PublishCompany.TabIndex = 2;
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(302, 221);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(192, 21);
            this.Page.TabIndex = 3;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(642, 77);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(192, 21);
            this.DateTimePicker.TabIndex = 4;
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(655, 202);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(179, 57);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "确认";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // BookLabel
            // 
            this.BookLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookLabel.Location = new System.Drawing.Point(40, 54);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(100, 23);
            this.BookLabel.TabIndex = 6;
            this.BookLabel.Text = "书名:";
            this.BookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WritterLabel
            // 
            this.WritterLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WritterLabel.Location = new System.Drawing.Point(300, 54);
            this.WritterLabel.Name = "WritterLabel";
            this.WritterLabel.Size = new System.Drawing.Size(100, 23);
            this.WritterLabel.TabIndex = 7;
            this.WritterLabel.Text = "作者:";
            this.WritterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.Location = new System.Drawing.Point(640, 51);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(100, 23);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "出版时间";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PublishLabel
            // 
            this.PublishLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublishLabel.Location = new System.Drawing.Point(40, 195);
            this.PublishLabel.Name = "PublishLabel";
            this.PublishLabel.Size = new System.Drawing.Size(100, 23);
            this.PublishLabel.TabIndex = 9;
            this.PublishLabel.Text = "出版社:";
            this.PublishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pagelabel
            // 
            this.Pagelabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pagelabel.Location = new System.Drawing.Point(297, 195);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(100, 23);
            this.Pagelabel.TabIndex = 10;
            this.Pagelabel.Text = "页数";
            this.Pagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InformationLabel
            // 
            this.InformationLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InformationLabel.Location = new System.Drawing.Point(3, 0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(236, 37);
            this.InformationLabel.TabIndex = 11;
            this.InformationLabel.Text = "请输入新书籍的信息";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.PublishLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.WritterLabel);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.PublishCompany);
            this.Controls.Add(this.Writter);
            this.Controls.Add(this.BookName);
            this.Name = "AddBookControl";
            this.Size = new System.Drawing.Size(984, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Writter;
        private System.Windows.Forms.TextBox PublishCompany;
        private System.Windows.Forms.TextBox Page;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label WritterLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PublishLabel;
        private System.Windows.Forms.Label Pagelabel;
        private System.Windows.Forms.Label InformationLabel;
    }
}
