using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaaS
{
    public partial class Complain : Form
    {
        public Complain()
        {
            InitializeComponent();
        }
        //定义全局
        DataSet ds = new DataSet();
        //查询整张表的方法
        public void zhengzhang()
        {
            //查询投诉表以及状态表
            string selectSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name");
            ds = DBHELP.GetDataSet(selectSql);
            //取消自动生成列
            info_dgv.AutoGenerateColumns = false;
            info_dgv.DataSource = ds.Tables[0];//绑定数据源
        }
        //窗体加载事件
        private void Complain_Load(object sender, EventArgs e)
        {
            dateTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            zhengzhang();
            text2.Text = info_dgv.Rows.Count.ToString();
        }

        //刷新按钮点击事件
        private void refresh_Click(object sender, EventArgs e)
        {
            zhengzhang();
            text2.Text = info_dgv.Rows.Count.ToString();
        }
        //查询投诉信息按钮点击事件
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //声明变量存储时间
            string date = dateTime.Text;
            string date_2 = dateTime_and.Text;
            //判断截止日期是否大于起始日期
            DateTime time1 = Convert.ToDateTime(dateTime.Value.Date.ToString("yyyy-MM-dd"));
            DateTime time2 = Convert.ToDateTime(dateTime_and.Value.Date.ToString("yyyy-MM-dd"));
            if (!(DateTime.Compare(time1, time2) < 0))
            {
                MessageBox.Show("截止日期应大于起始日期！");
                return;
            }
            //查询投诉记录SQL语句
            string QuerSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name where crt.complain_name like '%{0}%' and cst.dispose_status='{3}' and crt.time between '{1}' and '{2}'  or crt.number='{0}' ", Key_tb.Text.Trim().ToUpper(), Convert.ToDateTime(date).ToString("yyyy-MM-dd"), Convert.ToDateTime(date_2).ToString("yyyy-MM-dd"), cbb_stata.Text);
            ds = DBHELP.GetDataSet(QuerSql);
            //取消自动生成列
            info_dgv.AutoGenerateColumns = false;
            //填充数据集
            info_dgv.DataSource = ds.Tables[0];
            text2.Text = info_dgv.Rows.Count.ToString();
            if (ds.Tables[0].Rows.Count <= 0)
            {
                text2.Text = info_dgv.Rows.Count.ToString();
                MessageBox.Show("未找到相关信息，请核对！", "提示");//弹框提示
                return;
            }
        }

        //private void btn_tou_Click(object sender, EventArgs e)
        //{
        //    //实例化窗体对象
        //    Complaint_Interface complaint_Interface = new Complaint_Interface();
        //    complaint_Interface.ShowDialog();//模式化窗口
        //}
        string id_1;
        string hao;
        private void info_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //选中行的ID
                id_1 = info_dgv.SelectedRows[0].Cells["col_name"].Value.ToString();
                hao = info_dgv.SelectedRows[0].Cells["col_num"].Value.ToString();
                //将表中的数据显示在文本框中
                this.num_tb.Text = info_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.dtp_date.Text = info_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.peplo_tb.Text = info_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Phone_tb.Text = info_dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.count_tb.Text = info_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                result_tb.Text = info_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请联系管理员！", "提示");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        { //声明变量存储结果
            bool result = true;
            bool result1 = true;
            if (info_dgv.SelectedRows.Count > 0)
            {
                //for循环选中行
                for (int i = 0; i < info_dgv.SelectedRows.Count; i++)
                {
                    string id_1 = info_dgv.SelectedRows[i].Cells["col_name"].Value.ToString();
                    //删除信息SQL语句
                    string sql = string.Format("delete from  complain_state_table  where complain_name='{0}' ", id_1);
                    result = DBHELP.ExecuteNonQuery(sql);
                    string sql2 = string.Format("delete from complain_register_table where complain_name='{0}' ", id_1);
                    result1 = DBHELP.ExecuteNonQuery(sql2);
                }
                //判断是否删除信息成功
                if (result&&result1)
                {
                    MessageBox.Show("删除成功", "删除");
                    //清空文本框并刷新列表 

                    this.num_tb.Text = "";
                    this.dtp_date.Text = "";
                    this.peplo_tb.Text = "";
                    this.Phone_tb.Text = "";
                    this.count_tb.Text = "";
                    zhengzhang();
                    text2.Text = info_dgv.Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("您未选中行！", "提示");
            }
        }

        private void btn_jiao_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(info_dgv.SelectedRows[0].Cells["col_id"].Value.ToString());//获取状态表的ID
            string Stat = info_dgv.SelectedRows[0].Cells["col_stae"].Value.ToString();//获取表中的办理状态
            //判断办理状态是否为“已办结”
            if (Stat == "已办结")
            {
                MessageBox.Show("办理状态已经是“已办结”，无法办理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹框提示
                return;
            }
            else if (result_tb.Text == "")
            {
                MessageBox.Show("处理结果不允许为空！", "提示");
                return;
            }
            else
            {
                //如果办理状态不是“已办结”，则提示用户是否将办理状态修改为已办结
                DialogResult result = MessageBox.Show("是否提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//弹框提示
                //判断用户选择的项，如果选择了“是”，则将办理状态修改为“已办结”
                if (result == DialogResult.Yes)
                {
                    string gaiSql = string.Format("update complain_state_table set dispose_status='已办结' where complain_id='{0}'", ID);
                    //判断数据库是否修改成功
                    if (DBHELP.ExecuteNonQuery(gaiSql))
                    {
                        string insertSql = string.Format("update complain_state_table set  result='{0}',receiver='系统管理员' where complain_name='{1}'", result_tb.Text, id_1);
                        if (DBHELP.ExecuteNonQuery(insertSql))
                        {
                            MessageBox.Show("受理编号：" + hao + "的投诉与建议处理完成！", "提示");
                            //成功修改办理状态后刷新列表
                            //刷新按钮点击事件
                            zhengzhang();
                            text2.Text = info_dgv.Rows.Count.ToString();
                            return;
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
