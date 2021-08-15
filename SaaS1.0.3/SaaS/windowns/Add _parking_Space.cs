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
//using static 汤臣一品小区物业管理系统.Main;
using static SaaS.Login;
     
namespace SaaS
{
    public partial class Add__parking_Space : Form
    {
        public Add__parking_Space()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }
      
        //定义全局
        DataSet ds = new DataSet();

        #region 窗体边框阴影效果变量申明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        #endregion
        private void Add__parking_Space_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);
            string selectSql = string.Format("select * from carport where ID='{0}'",cs.ID.id);
            ds = DBHELP.GetDataSet(selectSql);
            type11_tb.Text = ds.Tables[0].Rows[0]["Type"].ToString();
            Car_name_tb.Text = ds.Tables[0].Rows[0]["Car_name"].ToString();
            addres_tb.Text = ds.Tables[0].Rows[0]["Address"].ToString();
            tell_ttbb.Text = ds.Tables[0].Rows[0]["Tell"].ToString();
            Car_num_tb.Text = ds.Tables[0].Rows[0]["Car_num"].ToString();
            Car_typeee.Text = ds.Tables[0].Rows[0]["Car_type"].ToString();
            cs.info.num = type11_tb.Text;
            if (type11_tb.Text == "租用车位")
            {
                L1.Visible = true;
                years_tb.Visible = true;
                L2.Visible = true;
                a.Visible = true;
                c.Visible = true;
                d.Visible = true;
                e1.Visible = true;
                years_tb.Text = ds.Tables[0].Rows[0]["tenancy_term"].ToString();
            }
            if (type11_tb.Text == "私有车位")
            {
                Car_name_tb.DropDownStyle =ComboBoxStyle.DropDown;
                a.Visible = true;
                c.Visible = true;
                d.Visible = true;
                //查询职位表，并遍历所有的部门
                string SQL = "select * from owner_info_table";
                DataTable dt = DBHELP.GetDataTable(SQL);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.Car_name_tb.Items.Add(dt.Rows[i][2]);
                }
            }
            }

        private void btn_fan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          bool result= StopCar.IsVehicleNumber(Car_num_tb.Text);
            //非空验证 以及判断车位属性是不是私有车位
            if (type11_tb.Text=="私有车位")
            {
                if (Car_name_tb.Text==""|| tell_ttbb.Text==""|| Car_num_tb.Text==""|| Car_typeee.Text==""|| addres_tb.Text=="")
                {
                    MessageBox.Show(type11_tb.Text+" 所有信息不能为空！","提示");
                    return;
                }
            }
            if (type11_tb.Text == "租用车位")
            {
                if (Car_name_tb.Text == "" || tell_ttbb.Text == "" || Car_num_tb.Text == "" || Car_typeee.Text == "" || addres_tb.Text == ""||years_tb.Text=="")
                {
                    MessageBox.Show(type11_tb.Text + " 所有信息不能为空！", "提示");
                    return;
                }
            }
            if (Car_num_tb.Text=="")
            {
                MessageBox.Show("车牌号不能为空！","提示");
                return;
            }
            if (result==false)
            {
                MessageBox.Show("请输入正确的车牌号！","提示");
                return;
            }
            //电信手机号码正则        
            string dianxin = @"^1[35789][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);//实例化对象
                                            //联通手机号正则        
            string liantong = @"^1[345678][01256]\d{8}$";
            Regex tReg = new Regex(liantong);//实例化对象
                                             //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);//实例化对象
                                           //判断输入的手机号码格式是否正确
            if (!(dReg.IsMatch(tell_ttbb.Text) || tReg.IsMatch(tell_ttbb.Text) || yReg.IsMatch(tell_ttbb.Text)))
            {
                MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                tell_ttbb.Text = ""; //如果手机号码格式不正确则输入框变成空
                return;
            }
                if (type11_tb.Text == "私有车位")
                {
                //添加车位信息SQL语句
                string inserSql = string.Format("update carport set Car_name='{0}',Address='{1}',Tell='{2}',Car_num='{3}',Car_type='{4}',tenancy_term='30' where ID='{6}'", Car_name_tb.Text.Trim(), addres_tb.Text.Trim(), tell_ttbb.Text.Trim(), Car_num_tb.Text.Trim(), Car_typeee.Text.Trim(), years_tb.Text.Trim(), cs.ID.id);
                if (DBHELP.ExecuteNonQuery(inserSql))
                    {
                this.Close();
                    }
                }
            if (type11_tb.Text == "公共车位"|| type11_tb.Text == "租用车位")
            {
            //添加车位信息SQL语句
            string inserSQl = string.Format("update carport set Car_name='{0}',Address='{1}',Tell='{2}',Car_num='{3}',Car_type='{4}',tenancy_term='{5}' where ID='{6}'", Car_name_tb.Text.Trim(), addres_tb.Text.Trim(), tell_ttbb.Text.Trim(), Car_num_tb.Text.Trim(), Car_typeee.Text.Trim(),years_tb.Text.Trim(), cs.ID.id);
            if (DBHELP.ExecuteNonQuery(inserSQl))
                {
                    this.Close();
                }
            }
        }

        private void btn_xiu_Click(object sender, EventArgs e)
        {
            if (type11_tb.Text=="私有车位")
            {
            string xiuSql = string.Format("update carport set Car_name='{0}',Address='{1}',Tell='{2}',Car_num='{3}',Car_type='{4}',tenancy_term='30' where ID='{5}'", Car_name_tb.Text.Trim(), addres_tb.Text.Trim(), tell_ttbb.Text.Trim(), Car_num_tb.Text.Trim(), Car_typeee.Text.Trim(), cs.ID.id);
            if (DBHELP.ExecuteNonQuery(xiuSql))
            {
                MessageBox.Show("车位信息修改成功！","提示");
                this.Close();
            }
            }
            if (type11_tb.Text == "公共车位")
            {
                string xiuSql = string.Format("update carport set Car_name='{0}',Address='{1}',Tell='{2}',Car_num='{3}',Car_type='{4}' where ID='{5}'", Car_name_tb.Text.Trim(), addres_tb.Text.Trim(), tell_ttbb.Text.Trim(), Car_num_tb.Text.Trim(), Car_typeee.Text.Trim(), cs.ID.id);
                if (DBHELP.ExecuteNonQuery(xiuSql))
                {
                    MessageBox.Show("车位信息修改成功！", "提示");
                    this.Close();
                }
            }
            if (type11_tb.Text == "租用车位")
            {
                //添加车位信息SQL语句
                string inserSQl = string.Format("update carport set Car_name='{0}',Address='{1}',Tell='{2}',Car_num='{3}',Car_type='{4}',tenancy_term='{5}' where ID='{6}'", Car_name_tb.Text.Trim(), addres_tb.Text.Trim(), tell_ttbb.Text.Trim(), Car_num_tb.Text.Trim(), Car_typeee.Text.Trim(), years_tb.Text.Trim(), cs.ID.id);
                if (DBHELP.ExecuteNonQuery(inserSQl))
                {
                    MessageBox.Show("车位信息修改成功！", "提示");
                    this.Close();
                }
            }


        }

        private void Add__parking_Space_FormClosed(object sender, FormClosedEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 250, Win32.AW_BLEND | Win32.AW_HIDE);
        }
    }
}
