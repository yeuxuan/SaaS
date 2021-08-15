using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static SaaS.Login;

namespace SaaS
{
    public partial class regenist : Form
    {
        public regenist()
        {
            InitializeComponent();
        }

        private void regenist_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "业主";
            Win32.AnimateWindow(this.Handle, 600, Win32.AW_SLIDE);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Check()
        {
            string user = textBox3.Text.Trim();
            string pwd = textBox1.Text.Trim();
            string phone = textBox4.Text.Trim();
            string key = textBox5.Text.Trim();
            if (user == "")
            {
                MessageBox.Show("账号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {


                string sql = string.Format("select * from Users where usersnum='{0}'", user);
                DataSet dts = DBHELP.GetDataSet(sql);

                string sql2 = string.Format("select * from userinfo_table where account_number='{0}'", user);
                DataSet dy = DBHELP.GetDataSet(sql2);

                string sql3 = string.Format("select * from Super_Admin where superuser='{0}'", user);
                DataSet da = DBHELP.GetDataSet(sql3);
                //MessageBox.Show(dt.Tables[0].Rows.Count.ToString());
                //MessageBox.Show(dy.Tables[0].Rows.Count.ToString());
                //MessageBox.Show(da.Tables[0].Rows.Count.ToString());
                if (dts.Tables.Count == 0 || dts.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("账号已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (dy.Tables.Count == 0 || dy.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("账号已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (da.Tables.Count == 0 || da.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("账号已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }

            }
            if (pwd == "")
            {
                MessageBox.Show("密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (pwd.Length < 6)
            {
                MessageBox.Show("密码不能小于6位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (phone.Length != 11 || phone == "")
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
                if (!(dReg.IsMatch(textBox4.Text) || tReg.IsMatch(textBox4.Text) || yReg.IsMatch(textBox4.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    textBox4.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return false;
                }
                else
                {
                    //查询数据库并判断输入的手机号是否已被注册
                    string strSQL = "select * from Users where usersPhone='" + this.textBox4.Text.ToString().Trim() + "'";
                    DataSet dt = DBHELP.GetDataSet(strSQL);
                    if (dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("该手机号已被注册！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
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

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    //验证已经通过

                    if (comboBox1.Text == "业主")
                    {
                        string sql = string.Format("insert into Users(usersnum,userspwd,usersPhone,userkey) values ('{0}','{1}','{2}','{3}');", textBox3.Text.Trim(), textBox1.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim());

                        bool cmd = DBHELP.ExecuteNonQuery(sql);
                        MessageBox.Show(cmd ? "注册成功！" : "注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);//弹框提示
                        if (cmd)
                        {
                            Hide();

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请联系管理员，错误代码为：" + ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string num = "";
            if (textBox3.TextLength == 18)
            {
                num = textBox3.Text;
            }
            if (textBox3.TextLength >= 18)
            {
                MessageBox.Show("输入过多不能大于18！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = num;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox1.PasswordChar == '*' ?
             '\0' : '*';
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox4.TextLength > 11)
            {
                MessageBox.Show("手机号只能为11位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "";
                textBox4.BackColor = Color.Red;
            }
            else
            {
                textBox4.BackColor = Color.White;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show("Key密保是由先锋团队创造的一种新型密码，主要用于找回密码时的找回密码key请保密！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static bool Iss = true;
        private void textBox5_MouseHover(object sender, EventArgs e)
        {

            if (Iss)
            {
                Iss = false;
                MessageBox.Show("Key密保是由先锋团队创造的一种新型密码，主要用于找回密码时的找回密码。请保密！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
