using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SaaS.Login;

namespace SaaS
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        //定义全局

        bool a;
        bool b;
        bool c;
        private void Update_Load(object sender, EventArgs e)
        {
            /*由左至右窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
            string selectsql1 = string.Format("select distinct room_number from owner_info_table");
            DataTable ds = DBHELP.GetDataTable(selectsql1);
            //遍历出所有的小区名
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                this.roomnum_cb.Items.Add(ds.Rows[i][0]);

            }
            string selectsql = string.Format("select a.room_number,b.electric_money,b.payment_status2,c.proper_money,c.payment_status3,d.payment_status1,d.water_money from owner_info_table a  join electric_cost_table b on a.room_number = b.room_number join propertyfee_table c on a.room_number = c.room_number join watercost_table d on a.room_number = d.room_number where a.room_number='{0}'", cs.ID.id);
            DataSet dt = DBHELP.GetDataSet(selectsql);
            roomnum_cb.Text = dt.Tables[0].Rows[0]["room_number"].ToString();
            tb_water.Text = dt.Tables[0].Rows[0]["water_money"].ToString();
            cb_water.Text = dt.Tables[0].Rows[0]["payment_status1"].ToString();
            tb_electric.Text = dt.Tables[0].Rows[0]["electric_money"].ToString();
            cb_electric.Text = dt.Tables[0].Rows[0]["payment_status2"].ToString();
            tb_wuyei.Text = dt.Tables[0].Rows[0]["proper_money"].ToString();
            cb_wuyei.Text = dt.Tables[0].Rows[0]["payment_status3"].ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //非空验证
            if (tb_water.Text == "" || cb_water.Text == "" || tb_electric.Text == "" || cb_electric.Text == "" || tb_wuyei.Text == "" || cb_wuyei.Text == "")
            {
                MessageBox.Show("输入内容不能为空！");
            }
            else
            {
                string sqlupdate1 = string.Format("update watercost_table set water_money='{0}', payment_status1='{1}',time1=getdate() where room_number='{2}'", tb_water.Text, cb_water.Text, roomnum_cb.Text);
                a = DBHELP.ExecuteNonQuery(sqlupdate1);
                string sqlupdate2 = string.Format("update electric_cost_table set electric_money='{0}',payment_status2='{1}' where room_number='{2}'", tb_electric.Text, cb_electric.Text, roomnum_cb.Text);
                b = DBHELP.ExecuteNonQuery(sqlupdate2);
                string sqlupdate3 = string.Format("update propertyfee_table set proper_money='{0}',payment_status3='{1}' where room_number='{2}'", tb_wuyei.Text, cb_wuyei.Text, roomnum_cb.Text);
                c = DBHELP.ExecuteNonQuery(sqlupdate3);
                //判断信息是否修改成功
                if (a || b || c)
                {
                    MessageBox.Show("缴费成功!","提示");
                //修改成功后清空文本框
                tb_electric.Text = "";
                tb_water.Text = "";
                tb_wuyei.Text = "";
                }
                else
                {
                    MessageBox.Show("缴费失败!","提示");
                }
            }
        }

        private void bt_esc_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Close();
        }

        private void Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            //由下至上的关闭动画
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_NEGATIVE | Win32.AW_HIDE);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
