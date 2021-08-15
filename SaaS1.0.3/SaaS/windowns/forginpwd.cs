using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static SaaS.Login;
namespace SaaS
{
    public partial class forginpwd : Form
    {
        public forginpwd()
        {
            InitializeComponent();
        }
        ValidCode validCode = new ValidCode(4, ValidCode.CodeType.Numbers);//实例化这个对象

        private void forginpwd_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//加载验证码图片
            Win32.AnimateWindow(this.Handle, 600, Win32.AW_SLIDE);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox1.PasswordChar == '*' ?
               '\0' : '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = textBox2.PasswordChar == '*' ?
              '\0' : '*';
        }
        private static bool Iss2 = true;
        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Key密保是由先锋团队创造的一种新型密码，主要用于找回密码时的找回密码。请保密！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (Iss2)
            {
                Iss2 = false;
                MessageBox.Show("Key密保是由先锋团队创造的一种新型密码，主要用于找回密码时的找回密码。请保密！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }
        private bool checkpwd()//检查账号密码是否为空
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("账号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox1.Text.Trim() != textBox2.Text.Trim())
            {
                MessageBox.Show("密码二次输入不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Key不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("验证码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!this.textBox5.Text.Equals(validCode.CheckCode))
                {
                    DialogResult result = MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox5.Focus();
                    this.textBox5.Text = "";
                    if (result == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
                        return false;
                    }


                }
                else
                {
                    return true;
                }
            }


            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (checkpwd())
            {
                string sql = string.Format("select * from Users where usersnum='{0}' and userkey='{1}';", textBox3.Text.Trim(), textBox4.Text.Trim());

                DataTable dt = DBHELP.DataTable(sql);
                // MessageBox.Show(dt.Rows.Count.ToString());
                if (dt.Rows.Count > 0)
                {

                    string cmd2 = string.Format("update Users set userspwd='{0}' where usersnum='{1}';", textBox2.Text.Trim(), textBox3.Text.Trim());
                    bool su = DBHELP.ExecuteNonQuery(cmd2);
                    MessageBox.Show(su ? "找回成功！" : "找回失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);//弹框提示
                    Hide();

                }
                // MessageBox.Show(dt.Rows[0][0].ToString());
                //string cmd = string.Format("select * from Users where usersnum='{0}' and userkey='{1}';", textBox3.Text.Trim(), textBox2.Text.Trim());
                //bool sqlcmd = DBHELP.ExecuteNonQuery(cmd);
                //MessageBox.Show(sqlcmd.ToString());
                //if (sqlcmd)
                //{
                //    string cmd2 = string.Format("update Users set userspwd='{0}' where usersnum='{1}';", textBox2.Text.Trim(), textBox3.Text.Trim());
                //    bool su = DBHELP.ExecuteNonQuery(cmd2);
                //    MessageBox.Show(su ? "找回成功！" : "找回失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);//弹框提示
                //    Hide();
                //}

            }
            else
            {
                MessageBox.Show("失败");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
