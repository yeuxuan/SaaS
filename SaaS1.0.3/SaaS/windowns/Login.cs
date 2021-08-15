using SaaS.windowns;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SaaS
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }



        #region 鼠标左键的事件
        private void small_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.FindForm().WindowState = FormWindowState.Minimized;
            }
        }
        private void max_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 拖动
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
        #endregion



        #region  窗体动画
        public class Win32
        {
            public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
            public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
            public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
            public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
            public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
            public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。
            public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
            public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
            public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(
              IntPtr hwnd, // handle to window
              int dwTime, // duration of animation
              int dwFlags // animation type
              );
        }

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        #endregion
        ValidCode validCode = new ValidCode(4, ValidCode.CodeType.Numbers);//实例化这个对象
        private void lpogin_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedText = "业主";
            if (File.Exists("D:/yz.txt"))
            {
                StreamReader reader = new StreamReader("D:/yz.txt");
                string yz = reader.ReadToEnd();
                this.comboBox1.SelectedIndex = Convert.ToInt32(yz);
                //  MessageBox.Show(yz);
                reader.Close();
              //  this.Dispose();
            }
            else
            {
                this.comboBox1.SelectedIndex = 0;
            }

            //


            Win32.AnimateWindow(this.Handle, 600, Win32.AW_BLEND);

            pictureBox1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//加载验证码图片




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string num = "";
            if (textBox2.TextLength == 18)
            {
                num = textBox2.Text;
            }
            if (textBox2.TextLength >= 18)
            {
                MessageBox.Show("输入过多不能大于18！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = num;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {

                if (check() == false)
                {
                    return;
                }

                if (comboBox1.Text == "管理员")
                {
                    string UsN = textBox2.Text;
                    string Pwd = textBox1.Text;
                    string cmdsql = string.Format("select * from userinfo_table where account_number='{0}' and password='{1}'", UsN, Pwd);
                    SqlDataReader reader = DBHELP.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        user = textBox2.Text;
                        StreamWriter writer = new StreamWriter("D:/yz.txt");
                        writer.Write((int)1);
                        writer.Flush();
                        writer.Close();
                        reader.Close();//关闭连接对象
                        this.Hide();//隐藏界面
                                    //  MessageBox.Show("成功");
                        Mian mian = new Mian();
                        mian.ShowDialog();
                        this.Dispose();//释放所有资源
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (comboBox1.Text == "业主")
                {
                    string UsN = textBox2.Text;
                    string Pwd = textBox1.Text;

                    string cmdsql = string.Format("select * from Users where usersnum='{0}' and userspwd='{1}'", UsN, Pwd);
                    SqlDataReader reader = DBHELP.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        user = textBox2.Text;
                        StreamWriter writer = new StreamWriter("D:/yz.txt");
                        writer.Write((int)0);
                        writer.Flush();
                        writer.Close();
                        reader.Close();
                        this.Hide();
                        Owner_User_Interface owner_User_Interface = new Owner_User_Interface();
                        owner_User_Interface.ShowDialog();
                       // this.Dispose();
                        // MessageBox.Show("成功");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (comboBox1.Text == "超级管理员")
                {
                    string UsN = textBox2.Text;
                    string Pwd = textBox1.Text;
                    string cmdsql = string.Format("select * from Super_Admin where superuser='{0}' and Pwd='{1}'", UsN, Pwd);
                    SqlDataReader reader = DBHELP.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        user = textBox2.Text;
                        StreamWriter writer = new StreamWriter("D:/yz.txt");
                        writer.Write((int)2);
                        writer.Flush();
                        writer.Close();
                        reader.Close();
                        this.Hide();
                        Super_Admin super_Admin = new Super_Admin();
                        super_Admin.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (!(comboBox1.Text == "业主" || comboBox1.Text == "管理员" || comboBox1.Text == "超级管理员"))
                {
                    MessageBox.Show("登录身份验证错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("登录身份验证错误！" + ex.Message, "提示");
            }


        }

        private bool check()
        {
            //非空验证
            if (this.textBox2.Text.ToString().Trim() == "" || this.textBox1.Text.ToString().Trim() == "")
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {

                if (this.textBox3.Text == "")
                {
                    MessageBox.Show("验证码不能为空,请输入验证码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    //!this.textBox3.Text.Equals(validCode.CheckCode)
                    //MessageBox.Show(validCode.CheckCode.ToString());
                    //this.textBox3.Text.Trim() != validCode.CheckCode.ToString().Trim()
                    if (!this.textBox3.Text.Equals(validCode.CheckCode))//验证是否输入正确
                    {
                        DialogResult result = MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.textBox3.Focus();
                        this.textBox3.Text = "";
                        if (result == DialogResult.OK)
                        {
                            pictureBox1.Image = Image.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
                        }
                        return false;
                    }
                }
            }
            //查询管理员信息表和业主用户中并判断是否存在该用户名
            string strSQL = "select * from userinfo_table where account_number='" + this.textBox2.Text.ToString().Trim() + "'";
            DataSet dt = DBHELP.GetDataSet(strSQL);
            string strSQL1 = "select * from Users where usersnum='" + this.textBox2.Text.ToString().Trim() + "'";
            DataSet dy = DBHELP.GetDataSet(strSQL1);
            string strSQL2 = "select * from Super_Admin where superuser='" + this.textBox2.Text.ToString().Trim() + "'";
            DataSet du = DBHELP.GetDataSet(strSQL2);

            if (!(dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0))
            {
                if (!(dy.Tables.Count == 0 || dy.Tables[0].Rows.Count > 0))
                {
                    if (!(du.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("用户不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                        return false;
                    }
                }
            }
            return true;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("是否退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("欢迎您的下次使用！再见！", "提示", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("最大化可能会导致界面异常是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //this.FindForm().WindowState = FormWindowState.Maximized;
                MessageBox.Show("错误不允许最大化!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // int mima = 0;
        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox1.PasswordChar == '*' ?
               '\0' : '*';
            //if (mima==0)
            //{
            //    textBox1.PasswordChar = '\0';
            //    mima += 1;
            //}
            //else if(mima==1)
            //{
            //    textBox1.PasswordChar = '*';
            //    mima -= 1;
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            regenist reg = new regenist();
            reg.ShowDialog();
            // Hide();
            Win32.AnimateWindow(this.Handle, 600, Win32.AW_HIDE);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            forginpwd forginpwd = new forginpwd();
            forginpwd.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        public static string user;
        public static string pwd;
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (check() == false)
                {
                    return;
                }

                if (comboBox1.Text == "管理员")
                {
                    string UsN = textBox2.Text;
                    string Pwd = textBox1.Text;
                    string cmdsql = string.Format("select * from userinfo_table where account_number='{0}' and password='{1}';", UsN, Pwd);
                    SqlDataReader reader = DBHELP.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        user = textBox2.Text;
                        StreamWriter writer = new StreamWriter("D:/yz.txt");
                        writer.Write((int)1);
                        writer.Flush();
                        writer.Close();
                        reader.Close();//关闭连接对象
                        this.Hide();//隐藏界面
                        Mian main1 = new Mian();
                        main1.ShowDialog();
                        // MessageBox.Show("成功");
                        this.Dispose();//释放所有资源

                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (comboBox1.Text == "业主")
                {
                    string UsN = textBox2.Text;
                    string Pwd = textBox1.Text;
                    string cmdsql = string.Format("select * from Users where usersnum='{0}' and userspwd='{1}'", UsN, Pwd);
                    SqlDataReader reader = DBHELP.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        user = textBox2.Text;
                        StreamWriter writer = new StreamWriter("D:/yz.txt");
                        writer.Write((int)0);
                        writer.Flush();
                        writer.Close();
                        reader.Close();
                        this.Hide();
                        Owner_User_Interface mian = new Owner_User_Interface();
                        mian.ShowDialog();
                        //  MessageBox.Show("成功");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (comboBox1.Text == "超级管理员")
                {
                    string UsN = textBox2.Text;
                    string Pwd = textBox1.Text;
                    string cmdsql = string.Format("select * from Super_Admin where superuser='{0}' and Pwd='{1}'", UsN, Pwd);
                    SqlDataReader reader = DBHELP.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        user = textBox2.Text;
                        StreamWriter writer = new StreamWriter("D:/yz.txt");
                        writer.Write((int)2);
                        writer.Flush();
                        writer.Close();
                        reader.Close();
                        this.Hide();
                        Super_Admin super_Admin = new Super_Admin();
                        super_Admin.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (!(comboBox1.Text == "业主" || comboBox1.Text == "管理员" || comboBox1.Text == "超级管理员"))
                {
                    MessageBox.Show("登录身份验证错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
