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
    public partial class DeleteUserControl : UserControl
    {

        //多线程进行反序列化
        public static List<User> remineder = Storage.Deserialize<User>(Storage.UserFile);
        static ThreadStart threadStart = new ThreadStart(Calculate);

        public DeleteUserControl()
        {
            InitializeComponent();
            ShowAllBook();
        }

        public static void Calculate()
        {
            remineder = Storage.Deserialize<User>(Storage.UserFile);
        }

        //刷新界面
        public void ShowAllBook()
        {
            Thread thread = new Thread(threadStart);
            thread.Start();

            IDTextBox.Clear();
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SexTextBox.Clear();
            EthnicTextBox.Clear();
            BrithdayTextBox.Clear();
            RegistTextBox.Clear();

            for (int i = 0; i < remineder.Count; i++)
            {
                int j = i + 1;
                UserDataGridView.Rows.Add(j.ToString(),remineder[i].ID,remineder[i].name, remineder[i].age, remineder[i].sex, remineder[i].ethnic, remineder[i].brithday, remineder[i].register);
            }
            thread.Abort();
        }

        private void RefresnButton_Click(object sender, EventArgs e)
        {
            UserDataGridView.Rows.Clear();
            ShowAllBook();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            string sex = SexTextBox.Text;
            string ethnic = EthnicTextBox.Text;
            string birthday = BrithdayTextBox.Text;
            string registday = RegistTextBox.Text;

            Thread thread = new Thread(threadStart);
            thread.Start();

            User userbook = new User();

            for (int i = 0; i < remineder.Count; i++)
            {
                if (id == remineder[i].ID && name == remineder[i].name && age == remineder[i].age && sex == remineder[i].sex
                    && ethnic == remineder[i].ethnic && birthday == remineder[i].brithday && registday == remineder[i].register)
                {
                    IsRightForm isright = new IsRightForm();
                    if (isright.show())
                    {
                        userbook.Delete(i);
                        UserDataGridView.Rows.Clear();
                        ShowAllBook();
                        MessageBox.Show("删除用户成功");
                        break;
                    }
                }
                else if (i == remineder.Count - 1)
                {
                    MessageBox.Show("输入信息有误");
                    break;
                }
            }
            //摧毁线程
            thread.Abort();
        }
    }
}
