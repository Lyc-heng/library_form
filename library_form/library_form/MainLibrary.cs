using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_form
{
    public partial class MainLibrary : Form
    {
        //存储按钮照片
        Button[] pictures;
        //添加书籍的控件
        AddBookControl addbook = null;
        //显示书籍的控件
        SearchBookControl showbooks = null;
        //删除书籍的控件
        DeleteBookControl deletebook = null;
        //添加用户的控件
        AddUserControl adduser = null;
        //删除用户的控件
        DeleteUserControl deleteuser = null;
        //搜索用户的控件
        SearchUserControl searchuser = null;
        //借阅书籍的控件
        BorrowBooksControl borrowbook = null;
        //归还书籍的控件
        BackBookControl backbook = null;
        public MainLibrary()
        {
            InitializeComponent();
            //初始化界面

            //初始化图标画面
            pictures = new Button[5];
            pictures[0] = FirstButton;
            pictures[1] = SecondButton;
            pictures[2] = ThirdButton;
            pictures[3] = FourthButton;
            pictures[4] = FifthButton;

            //订阅增加书籍的事件
            addbook = new AddBookControl();
            addbook.AddBook += new AddBookControl.DelegateHandle(AddABook);

            //显示书籍的控件
            showbooks = new SearchBookControl();
            //删除书籍的控件
            deletebook = new DeleteBookControl();
            //添加用户的控件
            adduser = new AddUserControl();
            adduser.AddAUser += new AddUserControl.DelegateHandle(AddAUser);
            //删除用户的控件
            deleteuser = new DeleteUserControl();
            //搜索用户的控件
            searchuser = new SearchUserControl();
            //借阅书籍的控件
            borrowbook = new BorrowBooksControl();
            //归还书籍的控件
            backbook = new BackBookControl();
            //初始化上方图标颜色
            BookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(194, 225, 255);
            for (int i = 0; i < 5; i++)
            {
                pictures[i].BackgroundImage = bookimageList.Images[i];
            }
            BookToolStripMenuItem.Checked = true;
        }

        //按钮一
        private void BookToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            BookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244,244,244);
            UserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            HelperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            for (int i = 0; i < 5; i++)
            {
                pictures[i].BackgroundImage = null;
                pictures[i].Visible = true;
                
            }
            for (int i = 0; i < 5; i++)
            {
                pictures[i].BackgroundImage = bookimageList.Images[i];
            }
            BookToolStripMenuItem.Checked = true;
            UserToolStripMenuItem.Checked = false;
            HelperToolStripMenuItem.Checked = false;
        }

        //按钮二
        private void UserToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            BookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            UserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            HelperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            for (int i = 0; i < 5; i++)
            {
                pictures[i].BackgroundImage = null;
                pictures[i].Visible = true;
            }
            for (int i = 0; i < 3; i++)
            {
                pictures[i].BackgroundImage = userimageList.Images[i];
            }
            pictures[3].Visible = false;
            pictures[4].Visible = false;
            BookToolStripMenuItem.Checked = false;
            UserToolStripMenuItem.Checked = true;
            HelperToolStripMenuItem.Checked = false;
        }

        //按钮三
        private void HelperToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            BookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            UserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            HelperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            for (int i = 0; i < 5; i++)
            {
                pictures[i].BackgroundImage = null;
                pictures[i].Visible = true;
            }
            for (int i = 0; i < 3; i++)
            {
                pictures[i].BackgroundImage = helperimageList.Images[i];
            }
            pictures[3].Visible = false;
            pictures[4].Visible = false;
            BookToolStripMenuItem.Checked = false;
            UserToolStripMenuItem.Checked = false;
            HelperToolStripMenuItem.Checked = true;
        }

        //按钮颜色更改
        private void BookToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            BookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(194, 225, 255);
        }

        //按钮颜色更改
        private void UserToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            UserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(194, 225, 255);
        }

        //按钮颜色更改
        private void HelperToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            HelperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(194, 225, 255);
        }

        //订阅添加书籍的控件
        private void AddABook(string name, string writter, string time, string publisher,string page)
        {
            //添加书籍，将书籍信息传到全局变量和本地
            Book reminder = new Book();
            reminder.name = name;
            reminder.writter = writter;
            reminder.time = time;
            reminder.publisher = publisher;
            reminder.page = page;

            reminder.Add();
        }

        //添加用户
        private void AddAUser(string name, string age, string sex, string ethnic, string brithday, string registerday)
        {
            User reminder = new User();
            reminder.name = name;
            reminder.age = age;
            reminder.sex = sex;
            reminder.ethnic = ethnic;
            reminder.brithday = brithday;
            reminder.register = registerday;

            reminder.Add();
        }

        //添加、更新控件
        private void AddCtrlIntoPanel(UserControl ctrl)
        {
            //更新下方的控件
            this.show_panel.Controls.Clear();
            this.show_panel.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;
        }

        //第一个按钮
        private void FirstButton_Click(object sender, EventArgs e)
        {
            
            if (BookToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(addbook);    //添加书籍的控件
            }
            else if (UserToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(adduser);    //添加用户的控件
            }
            else if (HelperToolStripMenuItem.Checked)
            {
                MessageBox.Show("姓名:李沅城\n" + "专业:2016信息安全\n" + "学号:201611123021\n");
            }
        }

        //第二个按钮
        private void SecondButton_Click(object sender, EventArgs e)
        {
            if (BookToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(deletebook);   //删除书籍的控件
            }
            else if (UserToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(deleteuser);     //删除用户的控件
            }
            else if (HelperToolStripMenuItem.Checked)
            {
                MessageBox.Show("使用了多线程、文件存储、事件绑定、委托与事件等知识点");
            }
        }

        //第三个按钮
        private void ThirdButton_Click(object sender, EventArgs e)
        {
            
            if (BookToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(showbooks);    //搜索书籍的控件
            }
            else if (UserToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(searchuser);   //搜索用户的控件
            }
            else if (HelperToolStripMenuItem.Checked)
            {
                this.Close();    //退出的操作
            }

        }

        //第四个按钮
        private void FourthButton_Click(object sender, EventArgs e)
        {
            if (BookToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(borrowbook);    //借阅书籍的控件
            }
        }

        //第五个按钮
        private void FifthButton_Click(object sender, EventArgs e)
        {
            if (BookToolStripMenuItem.Checked)
            {
                this.AddCtrlIntoPanel(backbook);    //还书的控件
            }
        }

        //左下角显示时间
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimetoolStripStatusLabel.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm");
        }

    }
}
