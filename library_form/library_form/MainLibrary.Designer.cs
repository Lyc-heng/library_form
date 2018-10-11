namespace library_form
{
    partial class MainLibrary
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLibrary));
            this.mainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.BookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.choice_panel = new System.Windows.Forms.Panel();
            this.FifthButton = new System.Windows.Forms.Button();
            this.FourthButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.bookimageList = new System.Windows.Forms.ImageList(this.components);
            this.userimageList = new System.Windows.Forms.ImageList(this.components);
            this.helperimageList = new System.Windows.Forms.ImageList(this.components);
            this.show_panel = new System.Windows.Forms.Panel();
            this.timestatusStrip = new System.Windows.Forms.StatusStrip();
            this.TimetexttoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimetoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.mainmenuStrip.SuspendLayout();
            this.choice_panel.SuspendLayout();
            this.timestatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenuStrip
            // 
            this.mainmenuStrip.AutoSize = false;
            this.mainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.HelperToolStripMenuItem});
            this.mainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainmenuStrip.Name = "mainmenuStrip";
            this.mainmenuStrip.Size = new System.Drawing.Size(984, 49);
            this.mainmenuStrip.TabIndex = 0;
            this.mainmenuStrip.Text = "menuStrip1";
            // 
            // BookToolStripMenuItem
            // 
            this.BookToolStripMenuItem.AutoSize = false;
            this.BookToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookToolStripMenuItem.Name = "BookToolStripMenuItem";
            this.BookToolStripMenuItem.Size = new System.Drawing.Size(88, 50);
            this.BookToolStripMenuItem.Text = "图书管理";
            this.BookToolStripMenuItem.MouseEnter += new System.EventHandler(this.BookToolStripMenuItem_MouseEnter);
            this.BookToolStripMenuItem.MouseLeave += new System.EventHandler(this.BookToolStripMenuItem_MouseLeave);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.AutoSize = false;
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(88, 50);
            this.UserToolStripMenuItem.Text = "用户管理";
            this.UserToolStripMenuItem.MouseEnter += new System.EventHandler(this.UserToolStripMenuItem_MouseEnter);
            this.UserToolStripMenuItem.MouseLeave += new System.EventHandler(this.UserToolStripMenuItem_MouseLeave);
            // 
            // HelperToolStripMenuItem
            // 
            this.HelperToolStripMenuItem.AutoSize = false;
            this.HelperToolStripMenuItem.Name = "HelperToolStripMenuItem";
            this.HelperToolStripMenuItem.Size = new System.Drawing.Size(88, 50);
            this.HelperToolStripMenuItem.Text = "软件声明";
            this.HelperToolStripMenuItem.MouseEnter += new System.EventHandler(this.HelperToolStripMenuItem_MouseEnter);
            this.HelperToolStripMenuItem.MouseLeave += new System.EventHandler(this.HelperToolStripMenuItem_MouseLeave);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "图书管理系统";
            this.notifyIcon.Visible = true;
            // 
            // choice_panel
            // 
            this.choice_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choice_panel.AutoSize = true;
            this.choice_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.choice_panel.Controls.Add(this.FifthButton);
            this.choice_panel.Controls.Add(this.FourthButton);
            this.choice_panel.Controls.Add(this.FirstButton);
            this.choice_panel.Controls.Add(this.SecondButton);
            this.choice_panel.Controls.Add(this.ThirdButton);
            this.choice_panel.Location = new System.Drawing.Point(0, 43);
            this.choice_panel.Name = "choice_panel";
            this.choice_panel.Size = new System.Drawing.Size(984, 90);
            this.choice_panel.TabIndex = 2;
            // 
            // FifthButton
            // 
            this.FifthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.FifthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FifthButton.FlatAppearance.BorderSize = 0;
            this.FifthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FifthButton.Location = new System.Drawing.Point(358, 0);
            this.FifthButton.Name = "FifthButton";
            this.FifthButton.Size = new System.Drawing.Size(88, 87);
            this.FifthButton.TabIndex = 12;
            this.FifthButton.UseVisualStyleBackColor = false;
            this.FifthButton.Click += new System.EventHandler(this.FifthButton_Click);
            // 
            // FourthButton
            // 
            this.FourthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.FourthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FourthButton.FlatAppearance.BorderSize = 0;
            this.FourthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourthButton.Location = new System.Drawing.Point(270, 0);
            this.FourthButton.Name = "FourthButton";
            this.FourthButton.Size = new System.Drawing.Size(88, 87);
            this.FourthButton.TabIndex = 11;
            this.FourthButton.UseVisualStyleBackColor = false;
            this.FourthButton.Click += new System.EventHandler(this.FourthButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.FirstButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.FirstButton.FlatAppearance.BorderSize = 0;
            this.FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstButton.Location = new System.Drawing.Point(6, 0);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(88, 87);
            this.FirstButton.TabIndex = 8;
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SecondButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SecondButton.FlatAppearance.BorderSize = 0;
            this.SecondButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondButton.Location = new System.Drawing.Point(94, 0);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(88, 87);
            this.SecondButton.TabIndex = 10;
            this.SecondButton.UseVisualStyleBackColor = false;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ThirdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThirdButton.FlatAppearance.BorderSize = 0;
            this.ThirdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdButton.Location = new System.Drawing.Point(182, 0);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(88, 87);
            this.ThirdButton.TabIndex = 9;
            this.ThirdButton.UseVisualStyleBackColor = false;
            this.ThirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // bookimageList
            // 
            this.bookimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bookimageList.ImageStream")));
            this.bookimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.bookimageList.Images.SetKeyName(0, "11.png");
            this.bookimageList.Images.SetKeyName(1, "22.png");
            this.bookimageList.Images.SetKeyName(2, "33.png");
            this.bookimageList.Images.SetKeyName(3, "44.png");
            this.bookimageList.Images.SetKeyName(4, "55.png");
            // 
            // userimageList
            // 
            this.userimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("userimageList.ImageStream")));
            this.userimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.userimageList.Images.SetKeyName(0, "66.png");
            this.userimageList.Images.SetKeyName(1, "77.png");
            this.userimageList.Images.SetKeyName(2, "88.png");
            // 
            // helperimageList
            // 
            this.helperimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("helperimageList.ImageStream")));
            this.helperimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.helperimageList.Images.SetKeyName(0, "99.png");
            this.helperimageList.Images.SetKeyName(1, "1010.png");
            this.helperimageList.Images.SetKeyName(2, "1313.png");
            // 
            // show_panel
            // 
            this.show_panel.Location = new System.Drawing.Point(0, 133);
            this.show_panel.Name = "show_panel";
            this.show_panel.Size = new System.Drawing.Size(984, 303);
            this.show_panel.TabIndex = 3;
            // 
            // timestatusStrip
            // 
            this.timestatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimetexttoolStripStatusLabel,
            this.TimetoolStripStatusLabel});
            this.timestatusStrip.Location = new System.Drawing.Point(0, 439);
            this.timestatusStrip.Name = "timestatusStrip";
            this.timestatusStrip.Size = new System.Drawing.Size(984, 22);
            this.timestatusStrip.TabIndex = 4;
            this.timestatusStrip.Text = "statusStrip1";
            // 
            // TimetexttoolStripStatusLabel
            // 
            this.TimetexttoolStripStatusLabel.Name = "TimetexttoolStripStatusLabel";
            this.TimetexttoolStripStatusLabel.Size = new System.Drawing.Size(63, 17);
            this.TimetexttoolStripStatusLabel.Text = "当前时间: ";
            // 
            // TimetoolStripStatusLabel
            // 
            this.TimetoolStripStatusLabel.Name = "TimetoolStripStatusLabel";
            this.TimetoolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.timestatusStrip);
            this.Controls.Add(this.show_panel);
            this.Controls.Add(this.choice_panel);
            this.Controls.Add(this.mainmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenuStrip;
            this.Name = "MainForm";
            this.Text = "图书管理系统";
            this.mainmenuStrip.ResumeLayout(false);
            this.mainmenuStrip.PerformLayout();
            this.choice_panel.ResumeLayout(false);
            this.timestatusStrip.ResumeLayout(false);
            this.timestatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelperToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel choice_panel;
        private System.Windows.Forms.ImageList bookimageList;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Button FifthButton;
        private System.Windows.Forms.Button FourthButton;
        private System.Windows.Forms.ImageList userimageList;
        private System.Windows.Forms.ImageList helperimageList;
        private System.Windows.Forms.Panel show_panel;
        private System.Windows.Forms.StatusStrip timestatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TimetexttoolStripStatusLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripStatusLabel TimetoolStripStatusLabel;
    }
}

