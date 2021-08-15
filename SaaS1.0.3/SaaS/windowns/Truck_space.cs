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
    public partial class Truck_space : Form
    {
        public Truck_space()
        {
            InitializeComponent();
        }
        private void shuju()
        {
            string SQL = string.Format("select COUNT(Type) from carport where Type = '公共车位'");
            ds = DBHELP.GetDataSet(SQL);
            cun.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void shuju1()
        {
            string SQL1 = string.Format("select COUNT(Type) from carport where Type = '私有车位'");
            ds = DBHELP.GetDataSet(SQL1);
            cun1.Text = ds.Tables[0].Rows[0][0].ToString();
        }
        private void shuju2()
        {
            string SQL2 = string.Format("select COUNT(Type) from carport where Type = '租用车位'");
            ds = DBHELP.GetDataSet(SQL2);
            cun2.Text = ds.Tables[0].Rows[0][0].ToString();
        }
        DataSet ds = new DataSet();
        private void Truck_space_Load(object sender, EventArgs e)
        {
            string sql = "select * from carport";
            ds = DBHELP.GetDataSet(sql);
            dgv_car.AutoGenerateColumns = false;//取消自动生成列
            dgv_car.DataSource = ds.Tables[0];//绑定数据源
            shuju();
            shuju1();
            shuju2();
        }
        
        private void btn_select_Click(object sender, EventArgs e)
        {
            if (cbb_type1.Text == "公共车位")
            {
                string chaSql = string.Format("select * from carport where Type='{0}'", cbb_type1.Text);
                ds = DBHELP.GetDataSet(chaSql);
                //取消自动生成列
                dgv_car.AutoGenerateColumns = false;
                dgv_car.DataSource = ds.Tables[0];
                shuju();
                cun1.Text = "0";
                cun2.Text = "0";
                if (dgv_car.Rows.Count <= 0)
                {
                    MessageBox.Show("没有找到相关的车位信息！", "提示");
                    return;
                }
            }
            if (cbb_type1.Text == "私有车位")
            {
                string chaSql = string.Format("select * from carport where Type='{0}'", cbb_type1.Text);
                ds = DBHELP.GetDataSet(chaSql);
                //取消自动生成列
                dgv_car.AutoGenerateColumns = false;
                dgv_car.DataSource = ds.Tables[0];
                shuju1();
                cun.Text = "0";
                cun2.Text = "0";
                if (dgv_car.Rows.Count <= 0)
                {
                    MessageBox.Show("没有找到相关的车位信息！", "提示");
                    return;
                }
            }
            if (cbb_type1.Text == "租用车位")
            {
                string chaSql = string.Format("select * from carport where Type='{0}'", cbb_type1.Text);
                ds = DBHELP.GetDataSet(chaSql);
                //取消自动生成列
                dgv_car.AutoGenerateColumns = false;
                dgv_car.DataSource = ds.Tables[0];
                shuju2();
                cun.Text = "0";
                cun1.Text = "0";
                if (dgv_car.Rows.Count <= 0)
                {
                    MessageBox.Show("没有找到相关的车位信息！", "提示");
                    return;
                }
            }
            if (cbb_type1.Text == "全部")
            {
                string chaSql = string.Format("select * from carport");
                ds = DBHELP.GetDataSet(chaSql);
                //取消自动生成列
                dgv_car.AutoGenerateColumns = false;
                dgv_car.DataSource = ds.Tables[0];
                shuju();
                shuju1();
                shuju2();
                if (dgv_car.Rows.Count <= 0)
                {
                    MessageBox.Show("没有找到相关的车位信息！", "提示");
                    return;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        { //非空验证
            if (cbb_type.Text == "")
            {
                MessageBox.Show("车位类型不可为空！", "提示");
                return;
            }
            if (num_tb.Text == "")
            {
                MessageBox.Show("车位数量应大于零！", "提示");
                return;
            }
            //数据添加
            int num = int.Parse(num_tb.Text);
            if (cbb_type.Text == "公共车位")
            {
                for (int i = 0; i < num; i++)
                {
                    string insrtSql = string.Format("insert carport(Type) values('{0}') ", cbb_type.Text);
                    if (DBHELP.ExecuteNonQuery(insrtSql))
                    {
                        continue;
                    }
                }
                string sql = "select * from carport";
                ds = DBHELP.GetDataSet(sql);
                dgv_car.AutoGenerateColumns = false;//取消自动生成列
                dgv_car.DataSource = ds.Tables[0];//绑定数据源
                shuju();
                return;
            }
            if (cbb_type.Text == "私有车位")
            {
                for (int i = 0; i < num; i++)
                {
                    string insrtSql = string.Format("insert carport(Type) values('{0}') ", cbb_type.Text);
                    if (DBHELP.ExecuteNonQuery(insrtSql))
                    {
                        continue;
                    }
                }
                string sql = "select * from carport";
                ds = DBHELP.GetDataSet(sql);
                dgv_car.AutoGenerateColumns = false;//取消自动生成列
                dgv_car.DataSource = ds.Tables[0];//绑定数据源
                shuju1();
                return;
            }
            if (cbb_type.Text == "租用车位")
            {
                for (int i = 0; i < num; i++)
                {
                    string insrtSql = string.Format("insert carport(Type) values('{0}') ", cbb_type.Text);
                    if (DBHELP.ExecuteNonQuery(insrtSql))
                    {
                        continue;
                    }
                }
                string sql = "select * from carport";
                ds = DBHELP.GetDataSet(sql);
                dgv_car.AutoGenerateColumns = false;//取消自动生成列
                dgv_car.DataSource = ds.Tables[0];//绑定数据源
                shuju2();
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = dgv_car.SelectedRows.Count;
                string bianhao = dgv_car.SelectedRows[0].Cells["col_shu"].Value.ToString();
                string key = dgv_car.SelectedRows[0].Cells["col_attribute"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("是否删除您选中的 " + key, "提示", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    string sSql = string.Format("select Car_num from carport where ID='{0}'", bianhao);
                    ds = DBHELP.GetDataSet(sSql);
                    if (ds.Tables[0].Rows[0][0].ToString() == "")
                    {
                        string delSql = string.Format("delete from carport where ID='{0}'", bianhao);
                        if (DBHELP.ExecuteNonQuery(delSql))
                        {
                            MessageBox.Show("成功","消息提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            shuju();
                            shuju1();
                            shuju2();
                            string sql = "select * from carport";
                            ds = DBHELP.GetDataSet(sql);
                            dgv_car.AutoGenerateColumns = false;//取消自动生成列
                            dgv_car.DataSource = ds.Tables[0];//绑定数据源
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("删除失败，原因：该车位不是空车位！", "提示");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请选中行！", "提示");
            }
        }
       
       
        private void dgv_car_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cs.ID.id = dgv_car.SelectedRows[0].Cells["col_shu"].Value.ToString();
            Add__parking_Space add__Parking_Space = new Add__parking_Space();
            add__Parking_Space.ShowDialog();
            string sql = "select * from carport";
            ds = DBHELP.GetDataSet(sql);
            dgv_car.AutoGenerateColumns = false;//取消自动生成列
            dgv_car.DataSource = ds.Tables[0];//绑定数据源
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
