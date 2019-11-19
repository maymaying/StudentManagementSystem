using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void myDefaultBtn_Click(object sender, EventArgs e)
        {
            if (txbUsr.Text == string.Empty || txbPwd.Text == string.Empty)
            {
                MessageBox.Show("信息不完整！", "提示");
                return;
            }
            if (!txbUsr.Text.Equals("admin") || !txbPwd.Text.Equals("admin"))
            {
                MessageBox.Show("用户名或密码不正确！", "提示");
            }
            else
            {
                Welcome.updateForm.Show();
                this.Close();
            }
        }

        private void myCancelBtn_Click(object sender, EventArgs e)
        {
            txbUsr.Clear();
            txbPwd.Clear();
        }

        private void txbUsr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
