using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SaaS.Login;

namespace SaaS
{
    public partial class Complaint_Interface : Form
    {
      
        public Complaint_Interface()
        {
            InitializeComponent(); 
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }
        #region 窗体边框阴影效果变量申明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        #endregion
        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>
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
        //定义全局
        DataSet ds = new DataSet();
        private void Complaint_Interface_Load(object sender, EventArgs e)
        {

            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
            /*由上至下窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);
            string selectsql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name where crt.complain_name='{0}'", cs.ID.id);
            DataSet dt = DBHELP.GetDataSet(selectsql);
            hao_tb.Text = dt.Tables[0].Rows[0]["number"].ToString();
            complain_date.Text = dt.Tables[0].Rows[0]["time"].ToString();
            cpname_tb.Text = dt.Tables[0].Rows[0]["complain_name"].ToString();
            neirong_tb.Text = dt.Tables[0].Rows[0]["complai_thing"].ToString();
            jieg_tb.Text = dt.Tables[0].Rows[0]["result"].ToString();
            evaluate_cbb.Text = dt.Tables[0].Rows[0]["evaluate"].ToString();
            if (evaluate_cbb.Text=="非常满意"|| evaluate_cbb.Text == "较满意" || evaluate_cbb.Text == "满意" || evaluate_cbb.Text == "一般" || evaluate_cbb.Text == "不满意" || evaluate_cbb.Text == "非常不满意" )
            {
                this.btn_evaluate.Enabled = false;
            }
        }
        //取消按钮点击事件
        private void btn_abolish_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            Close();
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {
            if (jieg_tb.Text=="")
            {
                MessageBox.Show("办理中，不可进行评价！请见谅！","提示");
                return;
            }
            //非空验证
            if (evaluate_cbb.Text=="")
            {
                MessageBox.Show("请选择对本次处理结果的评价！","提示");
                return;
            }
            //更新SQL语句
            string updateSql = string.Format("update complain_state_table set evaluate='{0}' where complain_id='{1}'", evaluate_cbb.Text,cs.info.num);
            if (DBHELP.ExecuteNonQuery(updateSql))
            {
                MessageBox.Show("感谢您的评价，我们会力争做到最好！","提示");
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
