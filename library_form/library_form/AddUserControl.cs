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
    public partial class AddUserControl : UserControl
    {
        public delegate void DelegateHandle(string name, string age, string sex, string ethnic, string brithday, string registerday);
        public event DelegateHandle AddAUser;

        public AddUserControl()
        {
            InitializeComponent();
        }

        public void OnTimeEventFuntion(string name, string age, string sex, string ethnic, string brithday, string registerday)
        {
            if (AddAUser != null)
            {
                AddAUser(name, age, sex, ethnic,brithday,registerday);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            IsRightForm isright = new IsRightForm();
            if (isright.show())
            {
                if (NameTextBox.Text != "" && AgeTextBox.Text != "" && SexTextBox.Text != "" && EthnicTextBox.Text != "")
                {
                    OnTimeEventFuntion(NameTextBox.Text, AgeTextBox.Text, SexTextBox.Text, EthnicTextBox.Text, BrithdayDateTimePicker.Value.ToString("yyyy-MM-dd"), RegisterDateTimePicker.Value.ToString("yyyy-MM-dd"));
                    NameTextBox.Clear();
                    AgeTextBox.Clear();
                    SexTextBox.Clear();
                    EthnicTextBox.Clear();
                    MessageBox.Show("新用户添加成功");
                }
                else
                {
                    MessageBox.Show("消息填写不完整");
                }
            }
        }
    }
}
