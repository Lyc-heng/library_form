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
    public partial class DeleteBookControl : UserControl
    {
        //多线程进行反序列化
        public static List<Book> remineder = Storage.Deserialize<Book>(Storage.BookFile);
        static ThreadStart threadStart = new ThreadStart(Calculate);

        public DeleteBookControl()
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
                BookDataGridView.Rows.Add(j.ToString(), remineder[i].ID, remineder[i].name, remineder[i].writter, remineder[i].time, remineder[i].publisher, remineder[i].page, remineder[i].borrow, remineder[i].startime, remineder[i].endtime);
            }

            //摧毁线程
            thread.Abort();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BookDataGridView.Rows.Clear();
            ShowAllBook();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string writter = WritterTextBox.Text;
            string time = TimeTextBox.Text;
            string publisher = PublishTextBox.Text;
            string page = PageTextBox.Text;
            string id = NumberTextBox.Text;

            Thread thread = new Thread(threadStart);
            thread.Start();

            Book deletebook = new Book();

            for (int i = 0; i < remineder.Count; i++)
            {
                if (name == remineder[i].name && writter == remineder[i].writter && time == remineder[i].time
                    && publisher == remineder[i].publisher && page == remineder[i].page && id == remineder[i].ID)
                {
                    IsRightForm isright = new IsRightForm();
                    if (isright.show())
                    {
                        deletebook.Delete(i);
                        BookDataGridView.Rows.Clear();
                        NumberTextBox.Clear();
                        NameTextBox.Clear();
                        WritterTextBox.Clear();
                        TimeTextBox.Clear();
                        PublishTextBox.Clear();
                        PageTextBox.Clear();
                        ShowAllBook();
                        break;
                    }
                }
                else if (i == remineder.Count - 1)
                {
                    MessageBox.Show("此书不存在");
                    break;
                }
            }
            //摧毁线程
            thread.Abort();
        }
    }
}
