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
    public partial class SearchUserControl : UserControl
    {

        //多线程进行反序列化
        public static List<User> remineder = Storage.Deserialize<User>(Storage.UserFile);
        static ThreadStart threadStart = new ThreadStart(Calculate);

        public SearchUserControl()
        {
            InitializeComponent();
            ShowAllBook();
        }

        //多线程完成反序列的工作
        public static void Calculate()
        {
            remineder = Storage.Deserialize<User>(Storage.UserFile);
        }

        //更新左侧和下方的列表
        public void ShowAllBook()
        {
            Thread thread = new Thread(threadStart);
            thread.Start();

            for (int i = 0; i < remineder.Count; i++)
            {
                NameDataGridView.Rows.Add(remineder[i].name);
            }
            if (remineder != null)
            {
                RefreshBorrowBook(remineder[0]);
            }
            thread.Abort();
        }

        //更新按钮，刷新界面
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            NameDataGridView.Rows.Clear();
            UserDataGridView.Rows.Clear();
            ShowAllBook();
        }

        //双击左侧列表时，将信息在右侧显示出来
        private void NameDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            User temp = remineder[0].Search("",NameDataGridView.CurrentCell.Value.ToString());
            if(temp != null)
            {
                IDTextBox.Text = temp.ID;
                NameTextBox.Text = temp.name;
                AgeTextBox.Text = temp.age;
                SexTextBox.Text = temp.sex;
                EthnicTextBox.Text = temp.ethnic;
                BrithdayTextBox.Text = temp.brithday;
                RegistTextBox.Text = temp.register;
                if (temp.books.Count != 0)
                {
                    RefreshBorrowBook(temp);
                }
                else
                {
                    UserDataGridView.Rows.Clear();
                }
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

        //点击搜索用户按钮时，将用户相关的信息在右边上方和下方显示出来
        private void SearchButton_Click(object sender, EventArgs e)
        {
            User temp = remineder[0].Search(SearchIDTextBox.Text, SearchNameTextBox.Text);
            if (temp != null)
            {
                IDTextBox.Text = temp.ID;
                NameTextBox.Text = temp.name;
                AgeTextBox.Text = temp.age;
                SexTextBox.Text = temp.sex;
                EthnicTextBox.Text = temp.ethnic;
                BrithdayTextBox.Text = temp.brithday;
                RegistTextBox.Text = temp.register;
                if (temp.books.Count != 0)
                {
                    RefreshBorrowBook(temp);
                }
                else
                {
                    UserDataGridView.Rows.Clear();
                }
            }
            
        }
    }
}
