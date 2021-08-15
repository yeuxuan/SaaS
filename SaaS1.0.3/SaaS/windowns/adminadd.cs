using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaaS.windowns
{
    public partial class adminadd : Form
    {
        public adminadd()
        {
            InitializeComponent();
        }

        private void adminadd_Load(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_xaio_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private bool Check()
        {
            if (text_num.Text == "")
            {
                MessageBox.Show("账号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //查询数据库并判断输入的手机号是否已被注册
                string strSQL = "select * from userinfo_table where account_number='" + this.text_num.Text.ToString().Trim() + "'";
                DataSet dt = DBHELP.GetDataSet(strSQL);
                if (dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("账号已被添加！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                    return false;
                }

            }
            if (Pwd_text.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tell_text.TextLength != 11 || tell_text.Text == "")
            {
                MessageBox.Show("手机号不能小于11位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //电信手机号码正则        
                string dianxin = @"^1[35789][01379]\d{8}$";
                Regex dReg = new Regex(dianxin);//实例化对象
                                                //联通手机号正则        
                string liantong = @"^1[345678][01256]\d{8}$";
                Regex tReg = new Regex(liantong);//实例化对象
                                                 //移动手机号正则        
                string yidong = @"^(134[0123456789]\d{7}|1[34578][012356789]\d{8})$";
                Regex yReg = new Regex(yidong);//实例化对象
                                               //判断输入的手机号码格式是否正确

                if (!(dReg.IsMatch(tell_text.Text) || tReg.IsMatch(tell_text.Text) || yReg.IsMatch(tell_text.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    tell_text.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return false;
                }
                else
                {

                    //查询数据库并判断输入的手机号是否已被注册
                    string strSQL = "select * from userinfo_table where user_tel='" + this.tell_text.Text.ToString().Trim() + "'";
                    DataSet dt = DBHELP.GetDataSet(strSQL);
                    if (dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("该手机号已被添加！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }



            }

            return false;






        }
        private void btn_infoadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check() == false)
                {
                    return;
                }

                string sql = string.Format("insert into userinfo_table(account_number,password,user_tel) values ('{0}','{1}','{2}')", text_num.Text.Trim(), Pwd_text.Text.Trim(), tell_text.Text.Trim());

                bool iss = DBHELP.ExecuteNonQuery(sql);

                MessageBox.Show(iss ? "添加成功！" : "添加失败！", "提示");
                if (iss)
                {
                    Hide();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
