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
    public partial class SearchBookControl : UserControl
    {
        //多线程进行反序列化
        public static List<Book> remineder = Storage.Deserialize<Book>(Storage.BookFile);
        static ThreadStart threadStart = new ThreadStart(Calculate);

        public SearchBookControl()
        {
            InitializeComponent();
            ShowAllBook();
        }

        //多线程反序列化
        public static void Calculate()
        {
            remineder = Storage.Deserialize<Book>(Storage.BookFile);
        }

        public void ShowAllBook()
        {
            Thread thread = new Thread(threadStart);
            thread.Start();

            for (int i = 0; i < remineder.Count; i++)
            {
                int j = i + 1;
                BookDataGridView.Rows.Add(j.ToString(),remineder[i].ID,remineder[i].name, remineder[i].writter, remineder[i].time, remineder[i].publisher, remineder[i].page, remineder[i].borrow,remineder[i].startime,remineder[i].endtime);
            }
            thread.Abort();
        }

        //刷新界面
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BookDataGridView.Rows.Clear();
            ShowAllBook();
        }

        //搜索功能实现
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string writter = WritterTextBox.Text;
            string time = TimeTextBox.Text;
            string publisher = PublishTextBox.Text;
            string page = PageTextBox.Text;
            string id = NumberTextBox.Text;
            Book reminder = new Book();

            List<Book> end = reminder.Search(id,name, writter, time, publisher, page);
            BookDataGridView.Rows.Clear();
            if (end.Count == 0)
            {
                MessageBox.Show("这本书不存在");
            }
            else
            {
                for (int i = 0; i < end.Count; i++)
                {
                    int j = i + 1;
                    BookDataGridView.Rows.Add(j.ToString(), end[i].ID,end[i].name, end[i].writter, end[i].time, end[i].publisher, end[i].page,end[i].borrow,end[i].startime,end[i].endtime);
                }
            }

        }
    }
}
