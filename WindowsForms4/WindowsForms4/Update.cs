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
    public partial class Update : Form
    {
        public static string path;
        public static string info;
        public Update()
        {
            InitializeComponent();
            path = @"C:\Users\Lenovo\Desktop\J[HBH1B`BN(JD%)~E_[6N{U.jpg";
            pictureBox1.Image = Image.FromFile(path);
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mySubmitBtn_Click(object sender, EventArgs e)
        {
            info = "学号：" + tbxId.Text + "\r\n";
            info += "姓名：" + tbxName.Text + "\r\n";
            foreach(Control control in gbxSex.Controls)
            {
                if((control as RadioButton).Checked)
                {
                    info += "性别：" + (control as RadioButton).Text;
                }
            }

            info += "\r\n爱好：";
            foreach (Control control in gbxFavor.Controls)
            {
                if ((control as CheckBox).Checked)
                {
                    info += (control as CheckBox).Text + " ";
                }
            }

            info += "\r\n出生日期：" + dateTimePicker1.Text;
            info += "\r\n专    业：" + comboBox1.Text;
            Welcome.browserForm = new Browser();
            Welcome.browserForm.Show();
            this.Opacity = 0;
            
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxSex_Enter(object sender, EventArgs e)
        {

        }

        private void gbxFavor_Enter(object sender, EventArgs e)
        {

        }
        
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //首先清除所有现有项
            listBox1.Items.Clear();
            //用 Add 方法插入新项
            listBox1.Items.Add("2019年度校优秀团员");
            listBox1.Items.Add("2019年度一等奖学金");
            //用 Insert 方法插入新项
            listBox1.Items.Insert(2, "2019年度校运动会1000米游泳冠军");
            //使第二项选中
            //listBox1.SelectedIndex = 1;
            //获得添加的记录数
            string msg = string.Format("已添加奖惩记录{0}条", listBox1.Items.Count);
            MessageBox.Show(msg, "提示");
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = string.Format("现在时间：{0}", DateTime.Now.ToLongTimeString());
            //statusScripe1.Text = "现在时间：{0}"+DateTime.Now.ToString("hh:mm:ss").Trim();
            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
