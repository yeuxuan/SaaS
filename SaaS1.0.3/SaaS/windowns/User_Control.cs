using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaaS
{
    public partial class User_Control : Form
    {
        public User_Control()
        {
            InitializeComponent();
        }
        //定义全局
        DataSet ds = new DataSet();
        private void User_Control_Load(object sender, EventArgs e)
        {
            //查询业主用户信息表
            string Sql1 = "select * from Users";
            ds = DBHELP.GetDataSet(Sql1);
            //取消自动生成列
            dgv_u.AutoGenerateColumns = false;
            dgv_u.DataSource = ds.Tables[0];
            //查询管理员信息表
        }

        private void dgv_u_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //将表中的信息显示到文本框中
                this.tb_nyum.Text = dgv_u.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.tb_pwdd.Text = dgv_u.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.phone_tbb.Text = dgv_u     .Rows[e.RowIndex].Cells[2].Value.ToString();
                //当点击行时，文本框变为可编辑状态
                tb_nyum.ReadOnly = false;
                tb_pwdd.ReadOnly = false;
                phone_tbb.ReadOnly = false;
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确的地方！！！,", "提示");
            }
        }
        private void btn_dell_Click(object sender, EventArgs e)
        {
            string id = dgv_u.SelectedRows[0].Cells["num"].Value.ToString();
            DialogResult reslut = MessageBox.Show("是否要删除该用户？", "提示", MessageBoxButtons.YesNo);
            if (reslut == DialogResult.Yes)
            {
                string delSql = string.Format("delete from Users where UserID='{0}'", id);
                if (DBHELP.ExecuteNonQuery(delSql))
                {
                    MessageBox.Show("删除成功！");
                    //刷新列表
                    string Sql = "select * from Users";
                    ds = DBHELP.GetDataSet(Sql);
                    //取消自动生成列
                    dgv_u.AutoGenerateColumns = false;
                    dgv_u.DataSource = ds.Tables[0];
                    // 清空文本框
                    tb_nyum.Text = "";
                    tb_pwdd.Text = "";
                    phone_tbb.Text = "";
                    return;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
