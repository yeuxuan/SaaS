using System;
using System.Windows.Forms;

namespace SaaS
{
    public partial class Main1 : System.Windows.Forms.Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("是否退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("欢迎您的下次使用！再见！", "提示", MessageBoxButtons.OK);
                Application.Exit();
            }

        }

        private void 系统配置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test4546564456645");
        }

        private void 系统配置SToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 退出QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 添加住户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formadd add = new Formadd();
            add.ShowDialog();

        }

        private void 信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void 功能FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function function = new function();
            function.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
