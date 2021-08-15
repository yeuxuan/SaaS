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
    public partial class Repairs : Form
    {
        public Repairs()
        {
            InitializeComponent();
        }
        //定义全局
        DataSet DS = new DataSet();
        //窗体加载事件
        private void Repairs_Load(object sender, EventArgs e)
        {
            dateTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string StarSql = "select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name";
            DS = DBHELP.GetDataSet(StarSql);
            //取消自动生成列
            data_repairs.AutoGenerateColumns = false;
            data_repairs.DataSource = DS.Tables[0];
            text2.Text = data_repairs.Rows.Count.ToString();
        }
        //查询报修信息按钮的点击事件
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //声明变量存储时间
            string date = dateTime.Text;
            string date_2= dateTime_and.Text;
            //判断截止日期是否大于起始日期
            DateTime time1 = Convert.ToDateTime(dateTime.Value.Date.ToString("yyyy-MM-dd"));
            DateTime time2 = Convert.ToDateTime(dateTime_and.Value.Date.ToString("yyyy-MM-dd"));
            if (!(DateTime.Compare(time1,time2)<0))
            {
                MessageBox.Show("截止日期应大于起始日期！");
                return;
            }
            //非空验证
            if (water_NAme.Text == "" && date == "")
            {
                MessageBox.Show("必须选择一项！");
                return;
            }
            else
            {
                //查询保修记录SQL语句
                string QuerSql = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name where ret.proposer_name like '%{0}%' and ret.time between '{1}' and '{2}'  and rrt.repaircondition='{3}' ", water_NAme.Text.Trim(), Convert.ToDateTime(date).ToString("yyyy-MM-dd"), Convert.ToDateTime(date_2).ToString("yyyy-MM-dd"), cbb_stata.Text);
                DS = DBHELP.GetDataSet(QuerSql);
                //取消自动生成列
                data_repairs.AutoGenerateColumns = false;
                //填充数据集
                data_repairs.DataSource = DS.Tables[0];
                text2.Text = data_repairs.Rows.Count.ToString();
                if (DS.Tables[0].Rows.Count<=0)
                {
                    text2.Text = data_repairs.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息，请核对！","提示");
                    return;
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //实例化对象
        //    Repair_application repair_Application = new Repair_application();
        //    repair_Application.ShowDialog();
        //}
        //右键修改办理状态点击事件
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(data_repairs.SelectedRows[0].Cells["col_num"].Value.ToString());//获取状态表的ID
            string Stat = data_repairs.SelectedRows[0].Cells["col_Stata"].Value.ToString();
            if (Stat=="已受理")
            {
                MessageBox.Show("状态已经是“已受理”，无法修改！","提示");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("是否将办理状态改为已受理", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string gaiSql = string.Format("update repair_record_table set repaircondition='已受理' where repairrecord_id='{0}'", ID);
                    if (DBHELP.ExecuteNonQuery(gaiSql))
                    {
                        MessageBox.Show("修改成功！", "提示");
                        //刷新列表
                        //刷新按钮点击事件
                        string StarSql = "select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name";
                        DS = DBHELP.GetDataSet(StarSql);
                        //取消自动生成列
                        data_repairs.AutoGenerateColumns = false;
                        data_repairs.DataSource = DS.Tables[0];//绑定数据源
                        text2.Text = data_repairs.Rows.Count.ToString();
                        return;
                    }
                }
            }
           
        }
        int id;//定义全局
        private void data_repairs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //获取ID
                id = int.Parse(data_repairs.Rows[e.RowIndex].Cells[7].Value.ToString());
                //将表中的数据显示在文本框中
                this.dateTimeP.Text = data_repairs.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.name_tb1.Text = data_repairs.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.countinent.Text = data_repairs.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.address_tbb.Text = data_repairs.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.tel_tb.Text = data_repairs.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置！","错误");
            }
        }
        //刷新按钮点击事件
        private void refresh_Click_1(object sender, EventArgs e)
        {
            string StarSql = "select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name";
            DS = DBHELP.GetDataSet(StarSql);
            //取消自动生成列
            data_repairs.AutoGenerateColumns = false;
            data_repairs.DataSource = DS.Tables[0];//绑定数据源
            text2.Text = data_repairs.Rows.Count.ToString();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //声明变量存储结果
            bool result = true;
            if (data_repairs.SelectedRows.Count > 0)
            {
                //for循环选中行
                for (int i = 0; i < data_repairs.SelectedRows.Count; i++)
                {
                    string id_1 = data_repairs.SelectedRows[i].Cells["clo_Name"].Value.ToString();
                    //删除信息SQL语句
                    string sql = string.Format("delete from  repair_record_table  where proposer_name='{0}' ", id_1);
                    result = DBHELP.ExecuteNonQuery(sql);
                    string sql2 = string.Format("delete from repair_application_table where proposer_name='{0}' ", id_1);
                    result = DBHELP.ExecuteNonQuery(sql2);
                }
                //判断是否删除信息成功
                if (result)
                {
                    MessageBox.Show("删除成功", "删除");
                    //清空文本框并刷新列表 
                    this.dateTimeP.Text = "";
                    this.name_tb1.Text = "";
                    this.countinent.Text = "";
                    this.address_tbb.Text ="";
                    this.tel_tb.Text = "";
                    //Sql语句
                    string selectSql = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name");
                    DataTable dt = DBHELP.GetDataTable(selectSql);
                    //取消自动生成列
                    data_repairs.AutoGenerateColumns = false;
                    data_repairs.DataSource = dt;
                    text2.Text = data_repairs.Rows.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("您未选中行！", "提示");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void data_repairs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    // 把第3列显示*号，*号的个数统一设置成8个
        //    if (e.ColumnIndex == 4)
        //    {
        //        if (e.Value != null &&e.Value.ToString().Length >0)
        //        {
        //            e.Value = new string('*', 11);
        //        }
        //    }
        //}
    }
}
