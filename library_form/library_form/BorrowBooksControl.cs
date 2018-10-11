using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace library_form
{
    public partial class BorrowBooksControl : UserControl
    {
        //多线程进行反序列化图书信息
        public static List<Book> remineder = Storage.Deserialize<Book>(Storage.BookFile);
        static ThreadStart threadStart = new ThreadStart(Calculate);
        //多线程进行反序列化用户信息
        public static List<User> userremineder = Storage.Deserialize<User>(Storage.UserFile);
        static ThreadStart userthreadStart = new ThreadStart(Calculateuser);
        //借阅图书界面
        BorrowsUserForm borrowuser;
        //借阅图书的序号
        int booknumber = -1;

        public BorrowBooksControl()
        {
            InitializeComponent();
            //初始化借阅图书界面
            borrowuser = new BorrowsUserForm();

            ShowAllBook();
        }

        //刷新界面操作
        public void ShowAllBook()
        {
            Thread thread = new Thread(threadStart);
            Thread threaduse = new Thread(userthreadStart);
            threaduse.Start();
            thread.Start();

            for (int i = 0; i < remineder.Count; i++)
            {
                int j = i + 1;
                BookDataGridView.Rows.Add(j.ToString(), remineder[i].ID, remineder[i].name, remineder[i].writter, remineder[i].time, remineder[i].publisher, remineder[i].page, remineder[i].borrow, remineder[i].startime, remineder[i].endtime);
            }
            threaduse.Abort();
            thread.Abort();
        }

        //多线程反序列化图书信息
        public static void Calculate()
        {
            remineder = Storage.Deserialize<Book>(Storage.BookFile);
        }

        //多线程反序列化用户信息信息
        public static void Calculateuser()
        {
            userremineder = Storage.Deserialize<User>(Storage.UserFile);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BookDataGridView.Rows.Clear();
            ShowAllBook();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            if(booknumber != -1)
            {
                if(BookDataGridView.Rows[booknumber].Cells[7].Value.ToString() == "可以")
                {
                    //输入用户信息界面
                    string userinformation = borrowuser.ShowBorrow();
                    if (userinformation != "")
                    {
                        //分割字符串
                        string[] temp = Regex.Split(userinformation, " ", RegexOptions.IgnoreCase);
                        //寻找用户信息
                        User tempuser = userremineder[0].Search(temp[0], temp[1]);
                        int userindex = 0;
                        if (tempuser != null)
                        {
                            for (int i = 0; i < userremineder.Count; i++)
                            {
                                if (tempuser.ID == userremineder[i].ID&&tempuser.name == userremineder[i].name)
                                {
                                    userindex = i;
                                    break;
                                }
                            }
                            //更新书籍信息，修改为不可借书状态
                            string bookstarttime = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
                            string bookendtime = DateTime.Now.AddDays(10).ToString("yyyy/MM/dd HH:mm");
                            remineder[booknumber].Update(booknumber, "不可以", bookstarttime, bookendtime);
                            //该用户借书记录更新
                            userremineder[0].UpdateBorrowBook(userindex, remineder[booknumber], bookstarttime, bookendtime);
                        }
                        else
                        {
                            MessageBox.Show("该用户不存在");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("该书已经被借阅出去");
                }

            }
            else
            {
                MessageBox.Show("请双击你要借阅的图书");
            }
            
        }

        private void BookDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //获取点击的图书的序号
            booknumber = BookDataGridView.CurrentRow.Index;
            //打印出点击图书的信息
            IDTextBox.Text = BookDataGridView.Rows[booknumber].Cells[1].Value.ToString();
            NameTextBox.Text = BookDataGridView.Rows[booknumber].Cells[2].Value.ToString();
            WritterTextBox.Text = BookDataGridView.Rows[booknumber].Cells[3].Value.ToString();
            TimeTextBox.Text = BookDataGridView.Rows[booknumber].Cells[4].Value.ToString();
            PublishTextBox.Text = BookDataGridView.Rows[booknumber].Cells[5].Value.ToString();
            PageTextBox.Text = BookDataGridView.Rows[booknumber].Cells[6].Value.ToString();
        }

    }
}
