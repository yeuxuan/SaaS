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
    public partial class StopCar : Form
    {
        public StopCar()
        {
            InitializeComponent();
        }
        //判断车牌号格式的方法
        public static bool IsVehicleNumber(string vehicleNumber)
        {
            bool result = false;
            //车牌号格式正则表达式
            if (vehicleNumber.Length == 7)
            {
                string express = @"^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4}[A-Z0-9挂学警港澳]{1}$";
                result = Regex.IsMatch(vehicleNumber, express);
            }
            return result;
        }
        //定义全局
        double price;
        int id;
        //添加停车信息按钮点击事件
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                //非空验证
                if (cbb_vageName.Text == "" || tb_carnum.Text == "")
                {
                    MessageBox.Show("所有内容不允许为空！", "提示");
                }
                else
                {
                    //判断车牌号
                    if (IsVehicleNumber(tb_carnum.Text) == false)
                    {
                        MessageBox.Show("请输入正确的车牌号！", "提示");
                        return;
                    }
                    else
                    {
                        string sqlinto = string.Format("insert stopcar_table(car_number,village_name) values ('{0}','{1}')", tb_carnum.Text, cbb_vageName.Text);
                        if (DBHELP.ExecuteNonQuery(sqlinto))
                        {
                            MessageBox.Show("停车成功", "停车");
                            //信息添加成功后刷新列表
                            DataSet dt = new DataSet();
                            string selectsql = string.Format("select * from stopcar_table ");
                            dt = DBHELP.GetDataSet(selectsql);
                            dgv_stopcar.DataSource = dt.Tables[0];//绑定数据源
                            dgv_stopcar.Columns["stopcar_id"].Visible = false;
                            //清空文本框
                            cbb_vageName.Text = "";
                            tb_carnum.Text = "";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("失败", "停车", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(tb_carnum.Text+"车已存在！","提示");
                return;
            }
        }
        //结账按钮点击事件
        private void btn_jz_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_money.Text == "" || tb_shishou.Text == "")
                {
                    MessageBox.Show("应付金额与实收金额不能为空！", "结算");
                    return;
                }
                //声明变量存储实收金额与应收金额
                double one = double.Parse(tb_money.Text);
                double two = double.Parse(tb_shishou.Text);
                //判断实收金额是否大于应收金额
                if (two < one)
                {
                    MessageBox.Show("输入的应付金额应比实收金额大！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    //定义变量存储用户选中表中某一行的ID
                    int id = int.Parse(dgv_stopcar.SelectedRows[0].Cells["stopcar_id"].Value.ToString());
                    //更新停车表中收费金额以及缴费状态
                    string updatesql = string.Format("update stopcar_table set state='已缴费',charge_amont='{0}' where stopcar_id='{2}'", tb_money.Text.Trim(),id);
                    DBHELP.ExecuteNonQuery(updatesql);
                    //声明变量存储结算成功后的弹框提示信息
                    string MO = "";
                    MO += "结算成功，\n车牌号：" + dgv_stopcar.SelectedRows[0].Cells[2].Value.ToString() + "\n应收：" + one + " 元;\n实收：" + two + " 元;\n找零：" + (two - one).ToString("F2") + " 元";
                    DialogResult result = MessageBox.Show(MO, "结算", MessageBoxButtons.OK);
                    //如果用户点击了“OK”则刷新列表数据
                    if (result == DialogResult.OK)
                    {
                        string Sql = "select * from stopcar_table";
                        DataSet ds = DBHELP.GetDataSet(Sql);
                        dgv_stopcar.DataSource = ds.Tables[0];//绑定数据源
                        dgv_stopcar.Columns["stopcar_id"].Visible = false;
                        //清空文本框
                        tb_money.Text = "";
                        tb_shishou.Text = "";
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请联系管理员！");
            }
        }
        //查询按钮点击事件
        private void btn_select_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            string selectsql = string.Format("select * from stopcar_table where car_number like '%{0}%'", tb_refer.Text);
            dt = DBHELP.GetDataSet(selectsql);
            dgv_stopcar.DataSource = dt.Tables[0];//绑定数据源
            dgv_stopcar.Columns["stopcar_id"].Visible = false;//隐藏ID列
        }

        private void dgv_stopcar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //获取用户选中表中行的ID
                id = int.Parse(dgv_stopcar.Rows[e.RowIndex].Cells["stopcar_id"].Value.ToString());
            }
            catch (Exception)
            {
                //异常处理
                MessageBox.Show("请点击正确位置！", "错误");
            }
        }
        //右键离开的点击事件
        private void 离开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string stat = dgv_stopcar.SelectedRows[0].Cells["col_state"].Value.ToString();
                if (stat=="已缴费")
                {
                    MessageBox.Show("车牌号为："+dgv_stopcar.SelectedRows[0].Cells[2].Value.ToString()+" 车主已离开","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                //当点击出库时，将当前时间添加到停车表中
                string updateSql = string.Format("update stopcar_table set leave_time=getdate() where stopcar_id='{0}'", id);
                if (DBHELP.ExecuteNonQuery(updateSql))
                {
                    //当添加成功后，查询当前id的停车信息，以便于结账
                    string selectSql = string.Format("select * from stopcar_table where stopcar_id='{0}'", id);
                    DataSet ds = DBHELP.GetDataSet(selectSql);
                    dgv_stopcar.DataSource = ds.Tables[0];
                    dgv_stopcar.Columns["stopcar_id"].Visible = false;
                    //将进入时间以及离开时间保存到DateTime类型当中
                    DateTime end = DateTime.Parse(this.dgv_stopcar.SelectedRows[0].Cells[4].Value.ToString());
                    DateTime start = DateTime.Parse(this.dgv_stopcar.SelectedRows[0].Cells[3].Value.ToString());
                    //两个时间相减 。默认得到的是 两个时间之间的天数，然后进行转换将这个天数转换成小时, 返回值是double类型的数据
                    double diffdate = (end - start).TotalHours;
                    //收费规则：
                    //如果停车时间在0-1小时间内，则收取5元的停车费；
                    //如果停车时间超过1小时，每超过一小时就按照3/小时+基本停车费5元收取停车费
                    if (diffdate > 0 && diffdate <= 1)
                    {
                        price = 5;
                        tb_money.Text = price.ToString("F2");
                    }
                    else
                    {
                        price = (diffdate - 1) * 6 + 5;
                        tb_money.Text = price.ToString("F2");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("错误");
            }
        }
        //窗体加载事件
        private void StopCar_Load(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();//实例化DataSet对象
            string selectsql = string.Format("select * from stopcar_table ");
            dt = DBHELP.GetDataSet(selectsql);
            dgv_stopcar.DataSource = dt.Tables[0];//绑定数据源
            dgv_stopcar.Columns["stopcar_id"].Visible = false;
            //查询楼盘表
            string selectsql1 = string.Format("select distinct village_name from property_table ");
            DataTable ds = DBHELP.GetDataTable(selectsql1);
            //遍历出所有的小区名
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                this.cbb_vageName.Items.Add(ds.Rows[i][0]);
            }
        }
        //右键删除停车信息点击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取用户选择某行的ID、车牌号以及缴费状态
            id = int.Parse(dgv_stopcar.SelectedRows[0].Cells["stopcar_id"].Value.ToString());
            string num = dgv_stopcar.SelectedRows[0].Cells["Colcarnum"].Value.ToString();
            string stae = dgv_stopcar.SelectedRows[0].Cells["col_state"].Value.ToString();
            //判断车主是否已缴费
            if (stae=="未缴费")
            {
                MessageBox.Show("删除失败！车牌号为："+num+" 的车主未缴费！","提示");
                return;
            }
            //删除车辆信息SQL语句
            string delSql = string.Format("delete stopcar_table where stopcar_id='{0}'", id);
            //判断是否删除成功
            if (DBHELP.ExecuteNonQuery(delSql))
            {
                MessageBox.Show("成功删除\n车牌号：" + num + "\n的停车信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹框提示
                //删除成功后刷新列表
                DataSet dt = new DataSet();//实例化DataSet对象
                string selectsql = string.Format("select * from stopcar_table ");
                dt = DBHELP.GetDataSet(selectsql);
                dgv_stopcar.DataSource = dt.Tables[0];//绑定数据源
                dgv_stopcar.Columns["stopcar_id"].Visible = false;//隐藏ID列
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
