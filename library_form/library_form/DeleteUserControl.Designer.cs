namespace library_form
{
    partial class DeleteUserControl
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
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEthnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.EthnicTextBox = new System.Windows.Forms.TextBox();
            this.BrithdayTextBox = new System.Windows.Forms.TextBox();
            this.RegistTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.EthnicLabel = new System.Windows.Forms.Label();
            this.BrithdayLabel = new System.Windows.Forms.Label();
            this.RegistLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RefresnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.UserID,
            this.UserName,
            this.UserAge,
            this.UserSex,
            this.UserEthnic,
            this.brithday,
            this.RegistDay});
            this.UserDataGridView.Location = new System.Drawing.Point(0, 121);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowTemplate.Height = 23;
            this.UserDataGridView.Size = new System.Drawing.Size(984, 182);
            this.UserDataGridView.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "序号";
            this.Number.Name = "Number";
            // 
            // UserID
            // 
            this.UserID.HeaderText = "ID";
            this.UserID.Name = "UserID";
            this.UserID.Width = 150;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "姓名";
            this.UserName.Name = "UserName";
            this.UserName.Width = 120;
            // 
            // UserAge
            // 
            this.UserAge.HeaderText = "年龄";
            this.UserAge.Name = "UserAge";
            // 
            // UserSex
            // 
            this.UserSex.HeaderText = "性别";
            this.UserSex.Name = "UserSex";
            // 
            // UserEthnic
            // 
            this.UserEthnic.HeaderText = "民族";
            this.UserEthnic.Name = "UserEthnic";
            // 
            // brithday
            // 
            this.brithday.HeaderText = "出生日期";
            this.brithday.Name = "brithday";
            this.brithday.Width = 150;
            // 
            // RegistDay
            // 
            this.RegistDay.HeaderText = "注册日期";
            this.RegistDay.Name = "RegistDay";
            this.RegistDay.Width = 150;
            // 
            // InformationLabel
            // 
            this.InformationLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InformationLabel.Location = new System.Drawing.Point(3, 0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(93, 31);
            this.InformationLabel.TabIndex = 1;
            this.InformationLabel.Text = "删除用户";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(8, 63);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 21);
            this.IDTextBox.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(132, 63);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 21);
            this.NameTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(256, 63);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 21);
            this.AgeTextBox.TabIndex = 4;
            // 
            // SexTextBox
            // 
            this.SexTextBox.Location = new System.Drawing.Point(380, 63);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(100, 21);
            this.SexTextBox.TabIndex = 5;
            // 
            // EthnicTextBox
            // 
            this.EthnicTextBox.Location = new System.Drawing.Point(504, 63);
            this.EthnicTextBox.Name = "EthnicTextBox";
            this.EthnicTextBox.Size = new System.Drawing.Size(100, 21);
            this.EthnicTextBox.TabIndex = 6;
            // 
            // BrithdayTextBox
            // 
            this.BrithdayTextBox.Location = new System.Drawing.Point(628, 63);
            this.BrithdayTextBox.Name = "BrithdayTextBox";
            this.BrithdayTextBox.Size = new System.Drawing.Size(100, 21);
            this.BrithdayTextBox.TabIndex = 7;
            // 
            // RegistTextBox
            // 
            this.RegistTextBox.Location = new System.Drawing.Point(752, 63);
            this.RegistTextBox.Name = "RegistTextBox";
            this.RegistTextBox.Size = new System.Drawing.Size(100, 21);
            this.RegistTextBox.TabIndex = 8;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 48);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(17, 12);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(130, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "姓名";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(254, 48);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(29, 12);
            this.AgeLabel.TabIndex = 11;
            this.AgeLabel.Text = "年龄";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(378, 48);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(29, 12);
            this.SexLabel.TabIndex = 12;
            this.SexLabel.Text = "性别";
            // 
            // EthnicLabel
            // 
            this.EthnicLabel.AutoSize = true;
            this.EthnicLabel.Location = new System.Drawing.Point(502, 48);
            this.EthnicLabel.Name = "EthnicLabel";
            this.EthnicLabel.Size = new System.Drawing.Size(29, 12);
            this.EthnicLabel.TabIndex = 13;
            this.EthnicLabel.Text = "民族";
            // 
            // BrithdayLabel
            // 
            this.BrithdayLabel.AutoSize = true;
            this.BrithdayLabel.Location = new System.Drawing.Point(628, 47);
            this.BrithdayLabel.Name = "BrithdayLabel";
            this.BrithdayLabel.Size = new System.Drawing.Size(53, 12);
            this.BrithdayLabel.TabIndex = 14;
            this.BrithdayLabel.Text = "出生日期";
            // 
            // RegistLabel
            // 
            this.RegistLabel.AutoSize = true;
            this.RegistLabel.Location = new System.Drawing.Point(752, 47);
            this.RegistLabel.Name = "RegistLabel";
            this.RegistLabel.Size = new System.Drawing.Size(53, 12);
            this.RegistLabel.TabIndex = 15;
            this.RegistLabel.Text = "注册日期";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(889, 25);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefresnButton
            // 
            this.RefresnButton.Location = new System.Drawing.Point(889, 72);
            this.RefresnButton.Name = "RefresnButton";
            this.RefresnButton.Size = new System.Drawing.Size(75, 23);
            this.RefresnButton.TabIndex = 17;
            this.RefresnButton.Text = "刷新";
            this.RefresnButton.UseVisualStyleBackColor = true;
            this.RefresnButton.Click += new System.EventHandler(this.RefresnButton_Click);
            // 
            // DeleteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefresnButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RegistLabel);
            this.Controls.Add(this.BrithdayLabel);
            this.Controls.Add(this.EthnicLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.RegistTextBox);
            this.Controls.Add(this.BrithdayTextBox);
            this.Controls.Add(this.EthnicTextBox);
            this.Controls.Add(this.SexTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "DeleteUserControl";
            this.Size = new System.Drawing.Size(984, 303);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEthnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistDay;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.TextBox EthnicTextBox;
        private System.Windows.Forms.TextBox BrithdayTextBox;
        private System.Windows.Forms.TextBox RegistTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label EthnicLabel;
        private System.Windows.Forms.Label BrithdayLabel;
        private System.Windows.Forms.Label RegistLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RefresnButton;
    }
}
