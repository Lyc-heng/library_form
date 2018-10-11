using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_form
{
    public partial class AddBookControl : UserControl
    {
        public delegate void DelegateHandle(string name,string writter,string time,string publisher,string page);
        public event DelegateHandle AddBook;

        public AddBookControl()
        {
            InitializeComponent();
        }

        public void OnTimeEventFuntion(string name, string writter, string time, string publisher,string page)
        {
            if (AddBook != null)
            {
                AddBook(name,writter,time,publisher,page);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if(BookName.Text != ""&&Writter.Text != ""&&Page.Text !=""&&PublishCompany.Text!="")
            {
                OnTimeEventFuntion(BookName.Text, Writter.Text, DateTimePicker.Value.ToString("yyyy-MM-dd"), PublishCompany.Text, Page.Text);
                BookName.Clear();
                Writter.Clear();
                PublishCompany.Clear();
                Page.Clear();
                MessageBox.Show("书籍加入成功");

            }

        }
    }
}
