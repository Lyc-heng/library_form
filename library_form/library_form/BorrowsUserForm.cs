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
    public partial class BorrowsUserForm : Form
    {
        //确认是否点下借书按钮
        private bool click_button = false;

        public BorrowsUserForm()
        {
            InitializeComponent();
        }

        private void IsRightButton_Click(object sender, EventArgs e)
        {
            click_button = true;
            this.Close();
        }

        public string ShowBorrow()
        {
            this.ShowDialog();
            if (click_button)
            {
                IsRightForm isright = new IsRightForm();
                if (isright.show())
                {
                    return IDTextBox.Text + " " + NameTextBox.Text;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

    }
}
