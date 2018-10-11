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
    public partial class IsRightForm : Form
    {
        private bool is_confirm = false;
        public IsRightForm()
        {
            InitializeComponent();
        }

        public bool show()
        {
            this.ShowDialog();
            return is_confirm;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            is_confirm = true;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
