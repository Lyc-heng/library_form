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

namespace library_form
{
    public partial class BackBookControl : UserControl
    {
        //多线程进行用户的反序列化
        public static List<User> remineder = Storage.Deserialize<User>(Storage.UserFile);
        public static List<Book> bookremineder = Storage.Deserialize<Book>(Storage.BookFile);
        static ThreadStart threadStart = new ThreadStart(Calculate);
        //暂存选中的用户
        User temp = null;

        public BackBookControl()
        {
            InitializeComponent();
        }

        //多线程完成反序列的工作
        public static void Calculate()
        {
            remineder = Storage.Deserialize<User>(Storage.UserFile);
            bookremineder = Storage.Deserialize<Book>(Storage.BookFile);
        }

        //更新反序列信息
        public void ShowAllBook()
        {
            Thread thread = new Thread(threadStart);
            thread.Start();
            IDTextBox.Clear();
            NameTextBox.Clear();
            thread.Abort();
        }

        private void IsRightButton_Click(object sender, EventArgs e)
        {
            temp = new User();

            //判断输入的用户是否存在，若存在用户的借阅情况是什么
            if (IDTextBox.Text != "" && NameTextBox.Text != "")
            {
                temp = remineder[0].Search(IDTextBox.Text, NameTextBox.Text);
                if(temp != null)
                {
                    RefreshBorrowBook(temp);
                }
            }
            else
            {
                MessageBox.Show("输入的用户信息不完整");
            }
        }

        //更新用户详细借出情况的信息
        private void RefreshBorrowBook(User index)
        {
            UserDataGridView.Rows.Clear();
            for (int z = 0; z < index.books.Count; z++)
            {
                int f = z + 1;
                UserDataGridView.Rows.Add(f.ToString(), index.books[z].ID, index.books[z].name,
                    index.books[z].writter, index.books[z].time, index.books[z].publisher,
                    index.books[z].page, index.books[z].startime, index.books[z].endtime);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UserDataGridView.Rows.Clear();
            ShowAllBook();
        }

        private void UserDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BackBookForm isright = new BackBookForm();
            if (isright.show())
            {
                //获取点击的图书的序号
                int booknumber = UserDataGridView.CurrentRow.Index;
                string id = UserDataGridView.Rows[booknumber].Cells[1].Value.ToString();
                string name = UserDataGridView.Rows[booknumber].Cells[2].Value.ToString();
                string writter = UserDataGridView.Rows[booknumber].Cells[3].Value.ToString();
                string time = UserDataGridView.Rows[booknumber].Cells[4].Value.ToString();
                string publisher = UserDataGridView.Rows[booknumber].Cells[5].Value.ToString();
                string page = UserDataGridView.Rows[booknumber].Cells[6].Value.ToString();

                //更改用户的借书情况，修改图书信息
                int userindex = 0;
                if (temp != null)
                {
                    for (int i = 0; i < remineder.Count; i++)
                    {
                        if (temp.ID == remineder[i].ID && temp.name == remineder[i].name)
                        {
                            userindex = i;
                            break;
                        }
                    }
                }
                remineder[0].BackBook(userindex, booknumber);
                bookremineder[0].BackBook(id, name, writter, time, publisher, page);
            }
        }
    }
}
