using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Owner_User_Interface : Form
    {
        public Owner_User_Interface()
        {
            m_aeroEnabled = false;
            InitializeComponent();
            this.Toll_Down.Click += Toll_Down_Click;
            this.maintain_Down.Click += maintain_Down_Click;
            this.customer_service.Click += customer_service_Click;
            this.UserDown.Click += UserDown_Click;
        }


//定义全局
// bool a;
//   bool b;
// bool c;
            string nom = Login.user;//调用

        #region
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect, // x-coordinate of upper-left corner
       int nTopRect, // y-coordinate of upper-left corner
       int nRightRect, // x-coordinate of lower-right corner
       int nBottomRect, // y-coordinate of lower-right corner
       int nWidthEllipse, // height of ellipse
       int nHeightEllipse // width of ellipse
    );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        #endregion
        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        #region 点击任务栏图标最小化
        // Minimize from taskbar  点击任务栏图标最小化
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        #endregion

        #region
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        #endregion


        //生成流水受理编号
        string txtbianhao = DateTime.Now.ToString("TCyyyyMMddHHmmss");
        //定义全局
        DataSet ds = new DataSet();
        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>

        #region 拖动窗口
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
       
        public void invit()  //背景变色的方法
        {
           
            Toll_Down.BackColor = Color.FromArgb(243, 243, 241);
            maintain_Down.BackColor = Color.FromArgb(243, 243, 241);
            customer_service.BackColor = Color.FromArgb(243, 243, 241);
            UserDown.BackColor = Color.FromArgb(243, 243, 241);
        }
        private void Owner_User_Interface_Load(object sender, EventArgs e)
        {
           
            lab_nam.Text = cs.info.num;
            //查询业主用户信息表
            string yzhuSql = string.Format("select * from Users where usersnum='{0}'", nom);
            DataRow dr = DBHELP.GetDataSet(yzhuSql).Tables[0].Rows[0];//创建新行
            //将表中的数据取到个人中心窗体的文本框中
            num_tb.Text = dr[1].ToString();
            pwd_tb.Text = dr[2].ToString();
            tell_tb.Text = dr[3].ToString();

            //查询业主信息表
            string selectsql1 = string.Format("select * from owner_info_table");
            DataTable dt1 = DBHELP.GetDataTable(selectsql1);
            //遍历出所有的房间号
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                this.roomnum_cb.Items.Add(dt1.Rows[i][1]);

            }
            roomnum_cb.SelectedIndex = 0;
            //查询投诉表以及状态表
            string selectSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name");
            ds = DBHELP.GetDataSet(selectSql);
            //取消自动生成列
            info_dgv.AutoGenerateColumns = false;
            info_dgv.DataSource = ds.Tables[0];//绑定数据源
            //查询保修表
            string StarSql = "select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name";
            ds = DBHELP.GetDataSet(StarSql);
            //取消自动生成列
            data_repairs.AutoGenerateColumns = false;
            data_repairs.DataSource = ds.Tables[0];
            //隐藏选项卡
            tc_info.TabPages[1].Parent = null;
            tc_info.TabPages[1].Parent = null;
            tc_info.TabPages[1].Parent = null;
            /*由左至右窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
            invit();
            Toll_Down.BackColor = Color.FromArgb(230, 230, 250);
           text.Text=info_dgv.Rows.Count.ToString();
            text2.Text = data_repairs.Rows.Count.ToString();
            //双缓冲，实现界面后台缓冲
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true); 
            this.UpdateStyles(); //更新
        }

        private void guanbi_MouseClick(object sender, MouseEventArgs e)
        {
            //判断是否是鼠标左键点击的关闭图标，如果是鼠标左键点击，则关闭窗体
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        private void guanbi_MouseEnter(object sender, EventArgs e)
        {
            guanbi.BackColor = Color.FromArgb(238,0,0);
        }

        #region
        private void guanbi_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 工具栏 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 550;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(guanbi, "关闭");//设置提示按钮和提示内容
        }
        #endregion
        private void guanbi_MouseLeave(object sender, EventArgs e)
        {
            guanbi.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void min_MouseClick(object sender, MouseEventArgs e)
        {
            //判断是否是鼠标左键点击的最小化图标，如果是鼠标左键点击，则窗体最小化
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        #region
        private void min_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 550;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(min, "最小化");//设置提示按钮和提示内容
        }
        #endregion
        private void customer_txtservice_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage3;
            tabPage3.Parent = tc_info;
            invit();
            customer_service.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void customer_service_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage3;
            tabPage3.Parent = tc_info;
            invit();
            customer_service.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void maintain_Down_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage2;
            tabPage2.Parent = tc_info;
            invit();
            maintain_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void UserDown_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage4;
            tabPage4.Parent = tc_info;
            invit();
            UserDown.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void maintain_Up_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage2;
            tabPage2.Parent = tc_info;
            invit();
            maintain_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void Useer_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage4;
            tabPage4.Parent = tc_info;
            invit();//背景变色
            UserDown.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void Toll_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage1;
            invit();
            Toll_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void Toll_Down_Click(object sender, EventArgs e)
        {
            //打开一个选项卡
            this.tc_info.SelectedTab = this.tabPage1;
            invit();
            Toll_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void refer_btn_Click(object sender, EventArgs e)
        { //声明变量存储时间
            string Time = date_Time.Text;
            //非空验证
            if (water_Nom.Text == "" || water_Num.Text == "" || Time == "" || water_Address.Text == "" || content.Text == "")
            {
                MessageBox.Show("* 号项不允许为空！！！", "报修", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹框提示
                return;
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
                string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
                Regex yReg = new Regex(yidong);//实例化对象
                                               //判断输入的手机号码格式是否正确
                if (!(dReg.IsMatch(water_Num.Text) || tReg.IsMatch(water_Num.Text) || yReg.IsMatch(water_Num.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    water_Num.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return;
                }
                else
                {
                    //查询是否已经提交过
                    string TiSql = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name where ret.proposer_name='{0}'", water_Nom.Text);
                    ds = DBHELP.GetDataSet(TiSql);
                    if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("您已经提交过了，请勿重复提交！", "提示");
                        return;
                    }
                    else
                    {
                        try
                        {
                            string AddSql = string.Format("insert repair_application_table values('{0}','{1}','{2}','{3}','{4}')", water_Nom.Text.Trim(), water_Num.Text.Trim(), Convert.ToDateTime(Time).ToString("yyyy-MM-dd"), water_Address.Text, content.Text);
                            string sql = string.Format("insert repair_record_table(proposer_name) values('{0}')", water_Nom.Text);
                            if (DBHELP.ExecuteNonQuery(AddSql))
                            {
                                if (DBHELP.ExecuteNonQuery(sql))
                                {
                                    MessageBox.Show("提交成功！", "提示");//弹框提示
                                                                   //清空文本框
                                    water_Nom.Text = "";
                                    water_Num.Text = "";
                                    Time = "";
                                    water_Address.Text = "";
                                    content.Text = "";
                                    //提交成功后刷新列表
                                    string StarSql = "select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name";
                                    ds = DBHELP.GetDataSet(StarSql);
                                    //取消自动生成列
                                    data_repairs.AutoGenerateColumns = false;
                                    data_repairs.DataSource = ds.Tables[0];//绑定数据源
                                    text2.Text = data_repairs.Rows.Count.ToString();
                                    return;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("请联系管理员！", "错误");
                        }
                    }
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void data_repairs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.water_Nom.Text = data_repairs.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.date_Time.Text = data_repairs.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.water_Address.Text = data_repairs.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.content.Text = data_repairs.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置！", "提示");
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {  //声明变量存储投诉时间
            string Time = complain_date.Text;
            //非空验证
            if (cpname_tb.Text == "" || Tel_tb.Text == "" || neirong_tb.Text == "")
            {
                MessageBox.Show("* 号项不允许为空，请核对！", "投诉",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);//弹框提示
                return;
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
                string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
                Regex yReg = new Regex(yidong);//实例化对象
                                               //判断输入的手机号码格式是否正确
                if (!(dReg.IsMatch(Tel_tb.Text) || tReg.IsMatch(Tel_tb.Text) || yReg.IsMatch(Tel_tb.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    Tel_tb.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return;
                }//查询是否已经提交过
                string TiSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name where crt.complain_name='{0}'", cpname_tb.Text);
                ds = DBHELP.GetDataSet(TiSql);
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("您已经提交过了，请勿重复提交！", "提示");
                    return;
                }
                else
                {  //添加投诉信息SQL语句
                    string insertSql = string.Format("insert complain_register_table values('{0}','{1}','{2}','{3}','{4}')", txtbianhao, Convert.ToDateTime(Time).ToString("yyyy-MM-dd"), cpname_tb.Text, Tel_tb.Text, neirong_tb.Text);
                    string intoSql = string.Format("insert complain_state_table(complain_name) values('{0}')", cpname_tb.Text);
                    //判断数据是否添加成功
                    if ((DBHELP.ExecuteNonQuery(insertSql)) && (DBHELP.ExecuteNonQuery(intoSql)))
                    {
                        MessageBox.Show("提交成功！", "提交");//弹框提示
                                                       //清空文本框
                        cpname_tb.Text = "";
                        Tel_tb.Text = "";
                        neirong_tb.Text = "";
                        jieguo_tb.Text = "";
                        //  提交成功后刷新列表
                        //查询投诉表以及状态表
                        string selectSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name");
                        ds = DBHELP.GetDataSet(selectSql);
                        //取消自动生成列
                        info_dgv.AutoGenerateColumns = false;
                        info_dgv.DataSource = ds.Tables[0];//绑定数据源
                        text.Text = info_dgv.Rows.Count.ToString();
                        return;
                    }
                }
            }
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要退出本次登录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();//隐藏上一个界面
                Login Lg = new Login();
                Lg.ShowDialog();//模式化窗体
                this.Dispose();//释放资源
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {  //非空验证
            if (tb_electric.Text == ""||roomnum_cb.Text==""||cbb_type.Text=="")
            {
                MessageBox.Show("输入内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbb_type.Text=="水费")
            {
                string sqlupdate1 = string.Format("update watercost_table set water_money='{0}',payment_status1='已缴费',time1=getdate() where room_number='{1}'", tb_electric.Text, roomnum_cb.Text);
                if (DBHELP.ExecuteNonQuery(sqlupdate1))
                {
                    MessageBox.Show("房间号："+roomnum_cb.Text+" 成功缴纳水费："+tb_electric.Text+"元","充值");
                    //清空文本框
                    tb_electric.Text = "";
                    return;
                }
            }
            else if (cbb_type.Text=="电费")
            {
                string sqlupdate2 = string.Format("update electric_cost_table set electric_money='{0}',payment_status2='已缴费',time2=getdate() where room_number='{1}'", tb_electric.Text, roomnum_cb.Text);
                if (DBHELP.ExecuteNonQuery(sqlupdate2))
                {
                    MessageBox.Show("房间号：" + roomnum_cb.Text + " 成功缴纳电费：" + tb_electric.Text + "元", "充值");
                    //清空文本框
                    tb_electric.Text = "";
                    return;
                }
            }
            else if (cbb_type.Text=="物业管理费")
            {
                string sqlupdate3 = string.Format("update propertyfee_table set proper_money='{0}',payment_status3='已缴费',time3=getdate() where room_number='{1}'", tb_electric.Text, roomnum_cb.Text);
                if (DBHELP.ExecuteNonQuery(sqlupdate3))
                {
                    MessageBox.Show("房间号：" + roomnum_cb.Text + " 成功缴纳物业管理费：" + tb_electric.Text + "元", "充值");
                    //清空文本框
                    tb_electric.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("缴费失败!请选择房间号！", "提示");
                 return;
            }
            #region
            //else
            //{
            // string sqlupdate1 = string.Format("update watercost_table set water_money='{0}',payment_status1='已缴费',time1=getdate() where room_number='{1}'", tb_water.Text, roomnum_cb.Text);
            //    a = DBHELP.ExecuteNonQuery(sqlupdate1);
            //string sqlupdate2 = string.Format("update electric_cost_table set electric_money='{0}',payment_status2='已缴费',time2=getdate() where room_number='{1}'", tb_electric.Text, roomnum_cb.Text);
            //    b = DBHELP.ExecuteNonQuery(sqlupdate2);
            // string sqlupdate3 = string.Format("update propertyfee_table set proper_money='{0}',payment_status3='已缴费',time3=getdate() where room_number='{1}'", tb_wuyei.Text, roomnum_cb.Text);
            //    c = DBHELP.ExecuteNonQuery(sqlupdate3);
            //    //判断信息是否修改成功
            //    if (a || b || c)
            //    {
            //        MessageBox.Show("缴费成功!", "提示");
            //        //修改成功后清空文本框
            //        tb_electric.Text = "";
            //        tb_water.Text = "";
            //        tb_wuyei.Text = "";
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("修改失败!请选择房间号！", "提示");
            //        return;
            //    }
            //}
            #endregion
        }
        
        private void btn_gai_Click(object sender, EventArgs e)
        {
            //非空验证
            if (pwd_tb.Text == "" || tell_tb.Text == "")
            {
                MessageBox.Show("修改内容不允许为空！！！", "修改", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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
            if (!(dReg.IsMatch(tell_tb.Text) || tReg.IsMatch(tell_tb.Text) || yReg.IsMatch(tell_tb.Text)))
            {
                MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                tell_tb.Text = ""; //如果手机号码格式不正确则输入框变成空
                return;
            }
            //修改用户信息SQL语句
            string updateSql = string.Format("update Users set userspwd='{0}',usersPhone='{1}' where usersnum='{2}'", pwd_tb.Text.Trim(), tell_tb.Text.Trim(), nom);
            //判断信息是否修改成功
            if (DBHELP.ExecuteNonQuery(updateSql))
            {
                MessageBox.Show("成功修改信息！", "修改");
                this.Hide();
                Login form1 = new Login();
                form1.ShowDialog();
                this.Dispose();
                //查询业主用户信息表刷新文本框
                string yzhuSql = string.Format("select * from Users where usersnum='{0}'", nom);
                DataRow dr = DBHELP.GetDataSet(yzhuSql).Tables[0].Rows[0];//创建新行
                //将表中的数据取到个人中心窗体的文本框中
                num_tb.Text = dr[1].ToString();
                pwd_tb.Text = dr[2].ToString();
                tell_tb.Text = dr[3].ToString();
                return;
            }
        }

        private void pb_set_MouseEnter(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 450;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(pb_set, "设置");//设置提示按钮和提示内容
        }

        private void pb_set_Click(object sender, EventArgs e)
        {
            invit();
            //判断控件的可见方式
            if (Set_the_box.Visible == true)
            {
                Set_the_box.Visible = false;
            }
            else
            {
                Set_the_box.Visible = true;
            }
        }

        private void About_Us_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rd = random.Next(6);
          //  MessageBox.Show(rd.ToString());

            if (rd == 0)
            {
                //   SaaS.windowns.Mian mian = new Mian();
                //   mian.BackColor = Color.Red;
                coping.BackColor = Color.Red;
                bt_add.BackColor = Color.Red;
                Set_the_box.BackColor = Color.Red;
                btn_c.BackColor = Color.Red;
                refer_btn.BackColor = Color.Red;
                btn_cx.BackColor = Color.Red;
                btn_submit.BackColor = Color.Red;
                btn_gai.BackColor = Color.Red;
                btn_exit.BackColor = Color.Red;
                ///


            }
            else if (rd == 1)
            {
                coping.BackColor = Color.AliceBlue;
                bt_add.BackColor = Color.AliceBlue;
                Set_the_box.BackColor = Color.AliceBlue;
                btn_c.BackColor = Color.AliceBlue;
                refer_btn.BackColor = Color.AliceBlue;
                btn_cx.BackColor = Color.AliceBlue;
                btn_submit.BackColor = Color.AliceBlue;
                btn_gai.BackColor = Color.AliceBlue;
                btn_exit.BackColor = Color.AliceBlue;
            }
            else if (rd == 2)
            {
                coping.BackColor = Color.BurlyWood;
                bt_add.BackColor = Color.BurlyWood;
                Set_the_box.BackColor = Color.BurlyWood;
                btn_c.BackColor = Color.BurlyWood;
                refer_btn.BackColor = Color.BurlyWood;
                btn_cx.BackColor = Color.BurlyWood;
                btn_submit.BackColor = Color.BurlyWood;
                btn_gai.BackColor = Color.BurlyWood;
                btn_exit.BackColor = Color.BurlyWood;
            }
            else if (rd == 3)
            {
                coping.BackColor = Color.CadetBlue;
                bt_add.BackColor = Color.CadetBlue;
                Set_the_box.BackColor = Color.CadetBlue;
                btn_c.BackColor = Color.CadetBlue;
                refer_btn.BackColor = Color.CadetBlue;
                btn_cx.BackColor = Color.CadetBlue;
                btn_submit.BackColor = Color.CadetBlue;
                btn_gai.BackColor = Color.CadetBlue;
                btn_exit.BackColor = Color.CadetBlue;
            }
            else if (rd == 4)
            {
                coping.BackColor = Color.Yellow;
                bt_add.BackColor = Color.Yellow;
                Set_the_box.BackColor = Color.Yellow;
                btn_c.BackColor = Color.Yellow;
                refer_btn.BackColor = Color.Yellow;
                btn_cx.BackColor = Color.Yellow;
                btn_submit.BackColor = Color.Yellow;
                btn_gai.BackColor = Color.Yellow;
                btn_exit.BackColor = Color.Yellow;
            }
            else if (rd == 5)
            {
                coping.BackColor = Color.Fuchsia;
                bt_add.BackColor = Color.Fuchsia;
                Set_the_box.BackColor = Color.Fuchsia;
                btn_c.BackColor = Color.Fuchsia;
                refer_btn.BackColor = Color.Fuchsia;
                btn_cx.BackColor = Color.Fuchsia;
                btn_submit.BackColor = Color.Fuchsia;
                btn_gai.BackColor = Color.Fuchsia;
                btn_exit.BackColor = Color.Fuchsia;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            if (cbb_ty.Text=="已受理")
            {
            //查询保修记录SQL语句
            string QuerSql = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name where rrt.repaircondition='{0}' ",cbb_ty.Text);
            ds = DBHELP.GetDataSet(QuerSql);
            //取消自动生成列
            data_repairs.AutoGenerateColumns = false;
            //填充数据集
            data_repairs.DataSource = ds.Tables[0];
                text2.Text = data_repairs.Rows.Count.ToString();
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    text2.Text = data_repairs.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息！", "提示");
                return;
            }
            }
            if(cbb_ty.Text=="受理中")
            {
                //查询关键字为‘受理中’的报修记录SQL语句
                string QuerSql2 = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name where rrt.repaircondition='{0}' ", cbb_ty.Text);
                ds = DBHELP.GetDataSet(QuerSql2);
                //取消自动生成列
                data_repairs.AutoGenerateColumns = false;
                //填充数据集
                data_repairs.DataSource = ds.Tables[0];
                text2.Text = data_repairs.Rows.Count.ToString();
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    text2.Text = data_repairs.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息！", "提示");
                    return;
                }
            }
            if(cbb_ty.Text=="全部")
            { 
                //查询关键字为‘全部’的报修记录SQL语句
                string QuerSql3 = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name  ");
                ds = DBHELP.GetDataSet(QuerSql3);
                //取消自动生成列
                data_repairs.AutoGenerateColumns = false;
                //填充数据集
                data_repairs.DataSource = ds.Tables[0];
                text2.Text = data_repairs.Rows.Count.ToString();
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    text2.Text = data_repairs.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息，请核对！", "提示");
                    return;
                }
            }
        }

        private void btn_cx_Click(object sender, EventArgs e)
        {
            if (cbb_ty1.Text=="已办结")
            {//查询投诉记录SQL语句
            string QuerSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name where  cst.dispose_status='{0}' ",  cbb_ty1.Text);
            ds = DBHELP.GetDataSet(QuerSql);
            //取消自动生成列
            info_dgv.AutoGenerateColumns = false;
            //填充数据集
            info_dgv.DataSource = ds.Tables[0];
                text.Text = info_dgv.Rows.Count.ToString();
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    text.Text = info_dgv.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息！", "提示");//弹框提示
                return;
            }
            }
            if (cbb_ty1.Text=="办理中")
            {
                //查询投诉记录SQL语句
                string QuerSql2 = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name where  cst.dispose_status='{0}' ", cbb_ty1.Text);
                ds = DBHELP.GetDataSet(QuerSql2);
                //取消自动生成列
                info_dgv.AutoGenerateColumns = false;
                //填充数据集
                info_dgv.DataSource = ds.Tables[0];
                text.Text = info_dgv.Rows.Count.ToString();
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    text.Text = info_dgv.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息！", "提示");//弹框提示
                    return;
                }
            }
            if (cbb_ty1.Text=="全部")
            {
                //查询投诉记录SQL语句
                string QuerSql2 = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name ");
                ds = DBHELP.GetDataSet(QuerSql2);
                //取消自动生成列
                info_dgv.AutoGenerateColumns = false;
                //填充数据集
                info_dgv.DataSource = ds.Tables[0];
                text.Text = info_dgv.Rows.Count.ToString();
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    text.Text = info_dgv.Rows.Count.ToString();
                    MessageBox.Show("未找到相关信息，请核对！", "提示");//弹框提示
                    return;
                }
            }
        }

        private void Owner_User_Interface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 250, Win32.AW_BLEND | Win32.AW_HIDE);
        }

        private void info_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.complain_date.Text = info_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.neirong_tb.Text = info_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.cpname_tb.Text = info_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.jieguo_tb.Text = info_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置！", "提示");
            }
        }

        private void info_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //获取房间号存储在ID类中
            cs.ID.id = info_dgv.SelectedRows[0].Cells["col_name"].Value.ToString();
            cs.info.num = info_dgv.SelectedRows[0].Cells["col_id"].Value.ToString();
            if (cs.ID.id == "")
            {
                MessageBox.Show("请点击正确位置！");
                return;
            }
            Complaint_Interface complaint_Interface = new Complaint_Interface();
            complaint_Interface.ShowDialog();//模式窗体
            //刷新数据
            string selectSql = string.Format("select * from complain_register_table crt join complain_state_table cst on crt.complain_name=cst.complain_name");
            ds = DBHELP.GetDataSet(selectSql);
            //取消自动生成列
            info_dgv.AutoGenerateColumns = false;
            info_dgv.DataSource = ds.Tables[0];//绑定数据源
        }

        private void label29_Click(object sender, EventArgs e)
        {
            //判断控件的可见方式
            if (Set_the_box.Visible == true)
            {
                Set_the_box.Visible = false;
            }
            else
            {
                Set_the_box.Visible = true;
            }
            //弹框提示关于程序
            MessageBox.Show("系统名称：SaSS小区物业管理系统\n团队名称：先锋团队\n团队负责人：刘强\n系统版本号：V 1.1.0\n发布日期：2020-06-10\n联系邮箱：487735913@qq.com\n所有权：先锋团队所有成员", "关于");

        }

        private void coping_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void roomnum_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maintain_Down_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
