using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static SaaS.Login;

namespace SaaS.windowns
{
    public partial class Super_Admin : Form
    {
        public Super_Admin()
        {
            InitializeComponent();
        }
        #region 拖动
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                case 0xA3:
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion
        private void coping_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
            //最小化
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //退出程序
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        DataSet ds = new DataSet();//

        private void Super_Admin_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);//动画 使用淡出效果
            string sql = "select * from userinfo_table";
            ds = DBHELP.GetDataSet(sql);//调用
            dataGridView1.AutoGenerateColumns = false;//取消自动生成Columns 列
            dataGridView1.DataSource = ds.Tables[0];//设置数据集
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_seclt_Click(object sender, EventArgs e)
        {
            string usernum = textBox1.Text.Trim();//空格
            DataView dataView = ds.Tables[0].DefaultView;//模拟数据集，
            dataView.RowFilter = string.Format("account_number like '%{0}%'", usernum);//条件查询
            dataGridView1.DataSource = dataView;//设置数据集 刷新

        }

        private void btn_amend_Click(object sender, EventArgs e)
        {
            adminadd admin_Add = new adminadd();
            admin_Add.ShowDialog();//打开一个新窗口
            //刷新列表
            string sql = "select * from userinfo_table";
            DataSet ds3 = DBHELP.GetDataSet(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds3.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminadd admin_Add = new adminadd();
            admin_Add.ShowDialog();
            //刷新列表
            string sql = "select * from userinfo_table";
            DataSet ds4 = DBHELP.GetDataSet(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds4.Tables[0];
        }

        private void 删除管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
         //   MessageBox.Show(id+name);
            DialogResult result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string sqlcmd = string.Format("delete from userinfo_table where user_id='{0}' and account_number='{1}';", id, name);

                bool iss = DBHELP.ExecuteNonQuery(sqlcmd);
                MessageBox.Show(iss ? "删除成功" : "删除失败", "提示");
                dataGridView1.Refresh();//刷新
                dataGridView1.Update();//更新
                //刷新数据
                string sql = "select * from userinfo_table";
                DataSet ds2 = DBHELP.GetDataSet(sql);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds2.Tables[0];
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void show()
        {
            int num = 0, num2 = 0;
            for (; num <= this.dataGridView1.ColumnCount - 1; num++)
            {
                for (; num2 <= this.dataGridView1.Columns.Count - 1; num2++)
                {
                    //窗口提示
                    MessageBox.Show(this.dataGridView1.Rows[num].Cells[num2].Value.ToString());
                    MessageBox.Show(num.ToString());
                }

            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // MessageBox.Show("Test");
            //string str2 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(str2);
            // show();

            //MessageBox.Show(num.ToString());
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    MessageBox.Show("Test");
            //}
        }

        private void btn_jin_Click(object sender, EventArgs e)
        {
            Mian mian = new Mian();
            mian.ShowDialog();
            Win32.AnimateWindow(this.Handle, 600, Win32.AW_SLIDE);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Gray;//设置背景颜色
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //检查是否按下回车键
            if (e.KeyCode == Keys.Enter)
            {
                string usernum = textBox1.Text.Trim();
                DataView dataView = ds.Tables[0].DefaultView;
                dataView.RowFilter = string.Format("account_number like '%{0}%'", usernum);
                dataGridView1.DataSource = dataView;

            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.Transparent;//设置背景颜色
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.Gray;//设置背景颜色
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            this.minimize.BackColor = Color.Transparent;//设置背景颜色
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
